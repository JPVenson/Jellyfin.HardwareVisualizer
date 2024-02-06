# Whitepaper on Testing methodology for the Scripts and Tools

This whitepaper is aiming to provide a common bases for evaluating the systems performance of a device and submit the data to the centralized HWA-Server. 
The goal is to provide all nessesary informations on how to obtain test data, process them and submit them in a shared way so that multiple implementations made over different systems may all create shared results.

## Version
- 0.00 Draft, 06.02.2024, JPVenson

# Abstract

this document follows the RFC2119 wording standard.
https://www.rfc-editor.org/rfc/rfc2119



All references to the HWA-Server are assumed to target the current running http server running at `https://jellyfin.jpb.software`.
All http calls are assumed to be requested from the same IP. 
All http results can be requested as `application/json` as well as `application/xml`, for the sake of this document; all return values are shown as JSON.

# HWA testing flow

A HWA client _must_ obtain a list of media files from the HWA server and only test the files that are returned by the server. 
The list of media files returned are comprised of a Source url of where to download the test media file in question as well as a matrix of resolutions to test.

## Obtaining Data
The media api can be expected to look like this:

```http
GET /api/v1/TestData
accept: application/json

---
content-type: application/json; charset=utf-8
{
  "token": "string",
  "ffmpeg": [
    "ffmpeg_source": "string",
    "ffmpeg_version": "string",
    "platform": "windows", "linux", "mac"
    "ffmpeg_hashs": [
      {
        "type": "md5",
        "hash": "string"
      },
      {
        "type": "sha256",
        "hash": "string"
      }
    ]
  ],
  "tests": [
    {
      "name": "string",
      "source_url": "string",
      "source_hashs": [
        {
          "type": "md5",
          "hash": "string"
        },
        {
          "type": "sha256",
          "hash": "string"
        }
      ],
      "test_type": "Transcode",
      "data": [
        {
          "id": "string",
          "from_resolution": "720p" | "1080p" | "2160p",
          "to_resolution": "720p" | "1080p" | "2160p",
          "bitrate": "number",
          "arguments": [
            {
              "type": "cpu" | "nvidia" | "amd" | "intel",
              "args": "string",
              "codec": "string",
            }
          ]
        }
      ]
    }
  ]  
}
```

> You may only obtain one valid set of TestData within a 1 hour timeframe. Once used to submit data, the endpoint will return a 429 status code with a Retry-after header indicating when to get new test data. You can call the endpoint 5 times within an 1 Hour timeframe without submitting data, obtaining the same token.

> Hint: in the future, the `test_type` might contain other values such as `Tonemap` or `remux` with alternating data structures. Your script should be aware and discard non supported values in an optimistic way.

after obtaining the list of media files, all media files **must** be downloaded invidvidually onto the persistent storage of the systems drive _or_ if a file with the same name is already present the download step can be skipped and only a hash validation **must** be done.
The user _should_ be able to select this folder invidiually and a note _should_ be printed that the fastest storage that is available to the user _should_ be used.
After downloading all media files, the HWA client **must** check for file integrity using one of the provided values in the `source_hash` list.

After obtaining all media files, the provided `ffmpeg_source` **must** be downloaded into a folder that is provided by the user. 
If an ffmpeg binary is already present or the binary was downloaded, a hash validation **must** be done.

If any hash validation fails, the user **must** be notified and the application **must** stop.

## Obtaining System Informations

The HWA client **must** obtain certain information about the host system to provide a conclusive overview of the systems resources.
The HWA client **must** provide at least obtain and provide the following data:

```json
{
    "os": {
      "name": "Windows" | "Linux" | "Mac",
      "version_id": "string",
      "version": "string",
    },
    "cpu": [
      {
        "product": "string",
        "vendor": "Intel" | "Amd" | "string",
      }
    ],
    "memory": [
      {
        "units": "bytes" | "megabytes" | "gigabytes",
        "size": 0
      }
    ],
    "gpu": [
      {
        "product": "string",
        "vendor": "Nvidia" | "Amd" | "Intel" | "string",       
      }
    ]
  }

```
### Windows specific values
For all windows versions,
- the `os.version_id` **must** contain the windows build number, such as `22631`.
- `os.version` _should_ contain the canonical version number, such as `Windows 11 version 23H2`

### Linux specific values
For all linux distributions,
- the `os.version_id` **must** contain the build number of the used distribution
- the `os.version` **must** contain the Distributions name

For example a Ubuntu version 22.04 will contain those values within the `/etc/*-release` file in the form of
```conf
DISTRIB_ID=Ubuntu
DISTRIB_RELEASE=22.04
```

### Hardware specifics

A Cpu _should_ report its canonical name in the product field such as `11th Gen Intel(R) Core(TM) i7-11700B @ 3.20GHz`. 
Further _should_ all variations of "Intel" or "Amd" product names be reduced to the short name of "Intel" and "Amd", e.g the HWA-Client _should_ trim an input such as "Intel Corp." to just "Intel".

Memory may be reported as either `b`, `mb` or `gb` for `bytes`, `megabytes` or `gigabytes`. Other denominations _should_ be converted to the corresponding expected values.

GPU values **must** be reported in the same manner as the CPU, `Nvidia` references _should_ be trimmed to just presenting the Nvidia vendor name and the Product **must** represent the canoncial display name.

#### Hardware specfics in Virtualized Enviroments
The HWA client **must** present a noticable and interactive warning that running the script within a virtual envirment, may degrade the performance to the client and may not represent the full capacity of the tested hardware.
The HWA client **must** provide a way to notify the client and set the `IsVirtualized` flag in the result document.

Virtual enviroments may report different product and vendors for CPU and GPU values. This **must** be handled by the client gracefully, you _may_ add an option to the client that allows to specify the product and vendor of the CPU and GPU values manually to circumvent this. For manual provided input, the same rules for sanitation apply. For example obtaining the GPU product and vendor while running within a WSL2 enviroment will report both as 
```
          product: Microsoft Corporation
          vendor: Microsoft Corporation
```


## Running the tests

To run the HWA tests, both the CPU and any GPU that is present in the system must be evaluated. Optionally the HWA client _should_ provide a method to only test either or selectivly one.
The HWA client **must** run each provided test returned from the `/api/v1/TestData` endpoint.
The HWA client **must** use a subprocess to run the specified ffmpeg binary with the provided `arguments` from the tests `data` properties that matches the tested hardware. 
Before executing the ffmpeg binary, the client **must** replace the `{video_file}` placeholder present in the `arguments` string with a path to the persisted media file. 

### Testing Selectors

The HWA client _should_ be configurable to select either a specific CPU, a specific GPU or both. You still **must** emit all hardware informations required.

### Testing Loop

The Testing loop **must** be constructed as followed:

- Spawn N+1 ffmpeg processes using the specificed ffmpeg binary and the corresponding argument for the given hardware and capture the stderr of all processes. The HWA Client _may_ also implement a more aggresive upscaling of workers as long as the last run before entering a failure reason was always a increment of N+1
- Wait until all processes exit
- Process all lines captured that match any `frame=(\d*)` where the frame is bigger then 500
- Obtain the `frame`, `speed`, `time` and `rss-kb` values that match the condition and calculate an average for the `speed` value over any single process
- Then calculate an average over all processes for the calculated `speed` and the last reported `time` values. For frame and rss-kb take the maximum values of any process.

After each run, add one process to run in parallel until either:
- The difference in speed between runs with more then 3 workers is less then 5 frames/sec 
- The average speed is below 1 frame/sec
- Any process returns an process `ExitCode` between (inclusive) 1-255
- Any process runs for more then 120sec

In case the average framerate does not change between runs, note this run's failure reason as: `failed_inconclusive`  
In case of the average framerate dropping below 1, note the failure reason as: `performance`  
In case of an `ExitCode` of an process that is between (inclusive) 1-255: look into the stderr of the process in question and search for all lines that match `failed -> (.*): (.*)` and use the reported values as failure reasons.  
In case of an timeout, note failure reason as: `failed_timeout`  

> Note: NVidia consumer GPUs have an build in limit on the number of concurrent NVENC streams. This has changed over the years from 2-3-5-8 streams depending on the driver. When detecting an Nvidia GPU and any transcode attempt fails at any of those threasholds and the error code is `out of memory (10): (no details)` you _may_ either discard the run and display an appropriate disclaimer; or you **must** use the `failed_nvenc_limit` error reason.  

If multiple failure reasons apply, add all of them to the result.

## Providing Result Data

The script **must** be able to output the result of the testing loop in a defined json or _may_ output in an xml document. The Json structure for a single run **must** be defined as follows:

```json
{
  "token": "string",

  "hwinfo": {
    "os": {
      "name": "Windows" | "Linux" | "Mac",
      "version_id": "string",
      "version": "string",
    },
    "cpu": [
      {
        "product": "string",
        "vendor": "Intel" | "Amd" | "string",
      }
    ],
    "memory": [
      {
        "units": "bytes" | "megabytes" | "gigabytes",
        "size": 0
      }
    ],
    "gpu": [
      {
        "product": "string",
        "vendor": "Nvidia" | "Amd" | "Intel" | "string",       
      }
    ]
  },
  "tests": [
    {
      "id": "string",
      "selected_gpu": 0,
      "selected_cpu": 0,
      "runs": [
        {
          "workers": 0,
          "frame": 0,
          "speed": 0,
          "time_s": 0,
          "rss_kb": 0
        }
      ],
      "results": {
        "max_streams": 0,
        "failure_reasons": [
          "string"
        ],
        "single_worker_speed": 0,
        "single_worker_rss_kb": 0
      }
    }
  ]
}
```

The `hwinfo` property **must** contain the informations gathered by the first step.   
The `tests` property **must** be a collection that references the individiual test loop run via the provided ID.   
The `tests.selected_gpu` and the `tests.selected_cpu` **must** reference a valid 0 based index within the collections of CPU's and GPU's respectivly for the individual used hardware. So a `nvenc_h265` encode that used the first gpu in the list of gpus the `selected_gpu` property must be 1. Omit the property that does not apply or use the value of `null` instead.   
The `tests.runs` collection **must** contain the individual results for each test loop where `workers` is the number of parallel ffmpeg processes that were spawned. It **must** only contain runs that did not fail with any reason.   

The `tests.results` object **must** contain the last run that did not have any failure reasons for the `max_streams`, `single_worker_speed`, `single_worker_rss_kb` properties and the failure reasons of the last, failed run.

The Token value **must** be the same as the token as returned from the `/api/v1/TestData` call and it must be used within 10-30 minutes only once.
If the HWA Client did run though in less then 10 minutes, the HWA client **must** wait and notify the user of the current state, the HWA client _may_ still provide the result as JSON either onto a GUI or to a file.   

The HWA tool _may_ also allow the user to post the results directly to the HWA server. 
This requires the user to interact with your application and be able to solve a CAPTCHA though an WebUI as this is required by the endpoint.  


--- to be explored later ---


After submitting the result document to 
```
POST /api/v1/SubmissionApi?captcha_token={token}
content-type: application/json
{
... contents of the result document  
}
```

The Api may either return with a 200 status code and responds with a body containing a GUID. 
This guid can be used to construct a url by means of `/survey?run={GUID}` which the HWA Client _may_ provide to the user or open for him in a web Browser.

## Cleanup

The HWA Client _may_ offer a method of deleting the downloaded files but _should_ not do that automatically 
