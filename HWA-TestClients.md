# Whitepaper on Testing methodology for the Scripts and Tools

This whitepaper is aiming to provide a common bases for evaluating the systems performance of a device and submit the data to the centralized HWA-Server. 
The goal is to provide all nessesary informations on how to obtain test data, process them and submit them in a shared way so that multiple implementations made over different systems may all create shared results.

## Version
- 0.00 Draft, 06.02.2024, JPVenson

All references to the HWA-Server are assumed to target the current running http server running at `https://jellyfin.jpb.software`.
All http calls are assumed to be requested from the same IP. 
All http results can be requested as `application/json` as well as `application/xml`, for the sake of this document; all return values are shown as JSON.

# HWA testing flow

A HWA client shall obtain a list of media files from the HWA server and only test the files that are returned by the server. 
The list of media files returned are comprised of a Source url of where to download the test media file in question as well as a matrix of resolutions to test.

## Obtaining Data
The media api can be expected to look like this:

```json
GET /api/v1/TestData
accept: application/json

---
content-type: application/json; charset=utf-8
{
  ffmpeg_source: string,
  ffmpeg_hashs: [
    {
      type: "md5",
      hash: string
    },
    {
      type: "sha256",
      hash: string
    }
  ],
  tests: [
    {
      name: string,
      token: string,
      source_url: string,
      source_hashs: [
        {
          type: "md5",
          hash: string
        },
        {
          type: "sha256",
          hash: string
        }
      ],
      test_type: "Transcode",
      data: [
        {
          from_resolution: "720p" | "1080p" | "2160p",
          to_resolution: "720p" | "1080p" | "2160p",
          bitrate: number,
          arguments: string
        }
      ]
    }
  ]  
}
```

> Hint: in the future, the `test_type` might contain other values such as `Tonemap` or `remux` with alternating data structures. Your script should be aware and discard non supported values in an optimistic way.

after obtaining the list of media files, all media files shall be downloaded invidvidually onto the persistent storage of the systems drive _or_ if a file with the same name is already present the download step can be skipped and only a hash validation *must* be done.
The user _should_ be able to select this folder invidiually and a note shall be printed that the fastest storage that is available to the user shall be used.
After downloading all media files, the HWA client *must* check for file integrity using one of the provided values in the `source_hash` list.

After obtaining all media files, the provided `ffmpeg_source` *must* be downloaded into a folder that is provided by the user. 
If an ffmpeg binary is already present or the binary was downloaded, a hash validation *must* be done.

If any hash validation fails, the user *must* be notified and the application *must* stop.

## Obtaining System Informations

The HWA client shall obtain certain information about the host system to provide a conclusive overview of the systems resources.
The HWA client *must* provide at least obtain and provide the following data:

```json
{
    "os": {
      "name": "Windows" | "Linux" | "Mac",
      "version_id": "string",
      "version": "string",
    },
    "cpu": [
      {
        "id": "string",
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
        "vendor": "string",       
      }
    ]
  }

```
### Windows specific values
For all windows versions,
- the `os.version_id` *must* contain the windows build number, such as `22631`.
- `os.version` *shall* contain the canonical version number, such as `Windows 11 version 23H2`

### Linux specific values
For all linux distributions,
- the `os.version_id` *must* contain the build number of the used distribution
- the `os.version` *must* contain the Distributions name

For example a Ubuntu version 22.04 will contain those values within the `/etc/*-release` file in the form of
```conf
DISTRIB_ID=Ubuntu
DISTRIB_RELEASE=22.04
```

### Hardware specifics

A Cpu _shall_ report its canonical name 


## Running the tests

To run the HWA tests, both the CPU and any GPU that is present in the system must be evaluated. Optionally the HWA client _shall_ provide a method to only test either or selectivly one.






















