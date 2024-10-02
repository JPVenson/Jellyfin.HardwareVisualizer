using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Jellyfin.HardwareVisualizer.Server.Database.Configuration;

public class TestCaseArgumentConfig : IEntityTypeConfiguration<TestCaseArgument>
{
    public void Configure(EntityTypeBuilder<TestCaseArgument> modelBuilder)
    {
        modelBuilder
            .HasData(new TestCaseArgument[]
            {
                new TestCaseArgument()
                {
                    FfmpegArgument = "-c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx264 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark",
                    TestCaseArgumentDeviceType = TestCaseArgumentDeviceType.Cpu,
                    FfmpegVersionGroupId  = FfmpegVersionConfig.GenericLinuxVersionGroup,
                    HardwareCodecId  = HardwareCodecConfig.h264CodecId,
                },
                new TestCaseArgument()
                {
                    FfmpegArgument = "-c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx265 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark",
                    TestCaseArgumentDeviceType = TestCaseArgumentDeviceType.Cpu,
                    FfmpegVersionGroupId  = FfmpegVersionConfig.GenericLinuxVersionGroup,
                    HardwareCodecId  = HardwareCodecConfig.hvecCodecId,
                },
                new TestCaseArgument()
                {
                    FfmpegArgument = "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v h264_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v h264_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark",
                    TestCaseArgumentDeviceType = TestCaseArgumentDeviceType.Nvidia,
                    FfmpegVersionGroupId  = FfmpegVersionConfig.GenericLinuxVersionGroup,
                    HardwareCodecId  = HardwareCodecConfig.h264CodecId,
                },
                new TestCaseArgument()
                {
                    FfmpegArgument = "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v hevc_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v hevc_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark",
                    TestCaseArgumentDeviceType = TestCaseArgumentDeviceType.Nvidia,
                    FfmpegVersionGroupId  = FfmpegVersionConfig.GenericLinuxVersionGroup,
                    HardwareCodecId  = HardwareCodecConfig.hvecCodecId,
                },
                new TestCaseArgument()
                {
                    FfmpegArgument = "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -hwaccel vaapi -hwaccel_output_format vaapi -c:v h264 -i {video_file} -noautoscale -an -sn -vf scale_vaapi=-1:{scale}:format=nv12 -c:v h264_vaapi -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark",
                    TestCaseArgumentDeviceType = TestCaseArgumentDeviceType.Amd,
                    FfmpegVersionGroupId  = FfmpegVersionConfig.GenericLinuxVersionGroup,
                    HardwareCodecId  = HardwareCodecConfig.h264CodecId,
                },
                new TestCaseArgument()
                {
                    FfmpegArgument = "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -hwaccel vaapi -hwaccel_output_format vaapi -c:v hevc -i {video_file} -noautoscale -an -sn -vf scale_vaapi=-1:{scale}:format=nv12 -c:v hevc_vaapi -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark",
                    TestCaseArgumentDeviceType = TestCaseArgumentDeviceType.Amd,
                    FfmpegVersionGroupId  = FfmpegVersionConfig.GenericLinuxVersionGroup,
                    HardwareCodecId  = HardwareCodecConfig.hvecCodecId,
                },
                new TestCaseArgument()
                {
                    FfmpegArgument = "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -init_hw_device qsv=qs@va -hwaccel qsv -hwaccel_output_format qsv -c:v h264_qsv -i {video_file} -noautoscale -an -sn -vf scale_qsv=-1:{scale}:format=nv12 -c:v h264_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark",
                    TestCaseArgumentDeviceType = TestCaseArgumentDeviceType.Intel,
                    FfmpegVersionGroupId  = FfmpegVersionConfig.GenericLinuxVersionGroup,
                    HardwareCodecId  = HardwareCodecConfig.h264CodecId,
                },
                new TestCaseArgument()
                {
                    FfmpegArgument = "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -init_hw_device qsv=qs@va -hwaccel qsv -hwaccel_output_format qsv -c:v hevc_qsv -i {video_file} -noautoscale -an -sn -vf scale_qsv=-1:{scale}:format=nv12 -c:v hevc_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark",
                    TestCaseArgumentDeviceType = TestCaseArgumentDeviceType.Intel,
                    FfmpegVersionGroupId  = FfmpegVersionConfig.GenericLinuxVersionGroup,
                    HardwareCodecId  = HardwareCodecConfig.hvecCodecId,
                },

				// Windows specifics: 3b20be6a-7c32-41a0-a6ca-259937e69512

				new TestCaseArgument()
                {
                    FfmpegArgument = "-c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx264 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark",
                    TestCaseArgumentDeviceType = TestCaseArgumentDeviceType.Cpu,
                    FfmpegVersionGroupId  = FfmpegVersionConfig.WindowsVersionGroup,
                    HardwareCodecId  = HardwareCodecConfig.h264CodecId,
                },
                new TestCaseArgument()
                {
                    FfmpegArgument = "-c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx265 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark",
                    TestCaseArgumentDeviceType = TestCaseArgumentDeviceType.Cpu,
                    FfmpegVersionGroupId  = FfmpegVersionConfig.WindowsVersionGroup,
                    HardwareCodecId  = HardwareCodecConfig.hvecCodecId,
                },
                new TestCaseArgument()
                {
                    FfmpegArgument = "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v h264_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v h264_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark",
                    TestCaseArgumentDeviceType = TestCaseArgumentDeviceType.Nvidia,
                    FfmpegVersionGroupId  = FfmpegVersionConfig.WindowsVersionGroup,
                    HardwareCodecId  = HardwareCodecConfig.h264CodecId,
                },
                new TestCaseArgument()
                {
                    FfmpegArgument = "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v hevc_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v hevc_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark",
                    TestCaseArgumentDeviceType = TestCaseArgumentDeviceType.Nvidia,
                    FfmpegVersionGroupId  = FfmpegVersionConfig.WindowsVersionGroup,
                    HardwareCodecId  = HardwareCodecConfig.hvecCodecId,
                },
                new TestCaseArgument()
                {
                    FfmpegArgument = "-init_hw_device d3d11va:{gpu} -hwaccel d3d11va -hwaccel_output_format d3d11 -c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=-1:{scale}:format=nv12\" -c:v h264_amf -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark",
                    TestCaseArgumentDeviceType = TestCaseArgumentDeviceType.Amd,
                    FfmpegVersionGroupId  = FfmpegVersionConfig.WindowsVersionGroup,
                    HardwareCodecId  = HardwareCodecConfig.h264CodecId,
                },
                new TestCaseArgument()
                {
                    FfmpegArgument = "-init_hw_device d3d11va:{gpu} -hwaccel d3d11va -hwaccel_output_format d3d11 -c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=-1:{scale}:format=nv12\" -c:v hevc_amf -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark",
                    TestCaseArgumentDeviceType = TestCaseArgumentDeviceType.Amd,
                    FfmpegVersionGroupId  = FfmpegVersionConfig.WindowsVersionGroup,
                    HardwareCodecId  = HardwareCodecConfig.hvecCodecId,
                },
                new TestCaseArgument()
                {
                    FfmpegArgument = "-init_hw_device d3d11va:{gpu} -hwaccel qsv -hwaccel_output_format qsv -c:v h264_qsv -i {video_file} -noautoscale -an -sn -vf \"scale_qsv=-1:{scale}:format=nv12\" -c:v h264_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark",
                    TestCaseArgumentDeviceType = TestCaseArgumentDeviceType.Intel,
                    FfmpegVersionGroupId  = FfmpegVersionConfig.WindowsVersionGroup,
                    HardwareCodecId  = HardwareCodecConfig.h264CodecId,
                },
                new TestCaseArgument()
                {
                    FfmpegArgument = "-init_hw_device d3d11va:{gpu} -hwaccel qsv -hwaccel_output_format qsv -c:v hevc_qsv -i {video_file} -noautoscale -an -sn -vf \"scale_qsv=-1:{scale}:format=nv12\" -c:v hevc_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark",
                    TestCaseArgumentDeviceType = TestCaseArgumentDeviceType.Intel,
                    FfmpegVersionGroupId  = FfmpegVersionConfig.WindowsVersionGroup,
                    HardwareCodecId  = HardwareCodecConfig.hvecCodecId,
                },
				// MacOS specifics
				new TestCaseArgument()
                {
                    FfmpegArgument = "-c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx264 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark",
                    TestCaseArgumentDeviceType = TestCaseArgumentDeviceType.Cpu,
                    FfmpegVersionGroupId  = FfmpegVersionConfig.MacVersionGroup,
                    HardwareCodecId  = HardwareCodecConfig.h264CodecId,
                },
                new TestCaseArgument()
                {
                    FfmpegArgument = "-c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx265 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark",
                    TestCaseArgumentDeviceType = TestCaseArgumentDeviceType.Cpu,
                    FfmpegVersionGroupId  = FfmpegVersionConfig.MacVersionGroup,
                    HardwareCodecId  = HardwareCodecConfig.hvecCodecId,
                },

            }.GetWithId());
    }
}
