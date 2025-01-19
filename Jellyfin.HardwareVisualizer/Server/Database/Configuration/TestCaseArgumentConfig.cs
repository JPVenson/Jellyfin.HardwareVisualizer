using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Jellyfin.HardwareVisualizer.Server.Database.Configuration;

public class TestCaseArgumentConfig : IEntityTypeConfiguration<TestCaseArgument>
{
    private class TestCaseGen
    {
        public string Template;
        public (Guid codec, string type)[] Source;
        public (Guid codec, string type)[] Target;
    }

    public void Configure(EntityTypeBuilder<TestCaseArgument> modelBuilder)
    {
        var generators = new Dictionary<(TestCaseArgumentDeviceType Device, Guid[] ffmpegGroup), TestCaseGen>()
        {
            {
             (TestCaseArgumentDeviceType.Cpu, [FfmpegVersionConfig.GenericLinuxVersionGroup, FfmpegVersionConfig.WindowsVersionGroup, FfmpegVersionConfig.MacVersionGroup]),
             new TestCaseGen(){
                Template = """-c:v {SOURCE} -i {video_file} -noautoscale -an -sn -vf "scale=trunc(min(max(iw\,ih*a)\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p" -c:v {TARGET} -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark""",
                Source = [
                    (HardwareCodecConfig.h264CodecId, "h264"),
                    (HardwareCodecConfig.hvecCodecId, "hevc"),
                    (HardwareCodecConfig.av1CodecId, "dav1d"),
                ],
                Target = [
                    (HardwareCodecConfig.h264CodecId, "libx264"),
                    (HardwareCodecConfig.hvecCodecId, "libx265"),
                    (HardwareCodecConfig.av1CodecId, "svt-av1"),
                ]
             }
            },
            {
             (TestCaseArgumentDeviceType.Nvidia, [FfmpegVersionConfig.GenericLinuxVersionGroup, FfmpegVersionConfig.WindowsVersionGroup]),
             new TestCaseGen(){
                Template = """-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v {SOURCE} -i {video_file} -noautoscale -an -sn -vf "scale_cuda=-1:{scale}:yuv420p" -c:v {TARGET} -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark""",
                Source = [
                    (HardwareCodecConfig.h264CodecId, "h264_cuvid"),
                    (HardwareCodecConfig.hvecCodecId, "hevc_cuvid"),
                    (HardwareCodecConfig.av1CodecId, "av1_cuvid"),
                ],
                Target = [
                    (HardwareCodecConfig.h264CodecId, "h264_nvenc"),
                    (HardwareCodecConfig.hvecCodecId, "hevc_nvenc"),
                    (HardwareCodecConfig.av1CodecId, "av1_nvenc"),
                ]
             }
            },
            {
             (TestCaseArgumentDeviceType.Amd, [FfmpegVersionConfig.GenericLinuxVersionGroup]),
             new TestCaseGen(){
                Template = """-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -hwaccel vaapi -hwaccel_output_format vaapi -c:v {SOURCE} -i {video_file} -noautoscale -an -sn -vf "scale_vaapi=-1:{scale}:format=nv12" -c:v {TARGET} -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark""",
                Source = [
                    (HardwareCodecConfig.h264CodecId, "h264"),
                    (HardwareCodecConfig.hvecCodecId, "hevc"),
                    (HardwareCodecConfig.av1CodecId, "dav1d"),
                ],
                Target = [
                    (HardwareCodecConfig.h264CodecId, "h264_vaapi"),
                    (HardwareCodecConfig.hvecCodecId, "hevc_vaapi"),
                    (HardwareCodecConfig.av1CodecId, "av1_vaapi"),
                ]
             }
            },
            {
             (TestCaseArgumentDeviceType.Amd, [FfmpegVersionConfig.WindowsVersionGroup]),
             new TestCaseGen(){
                Template = """-init_hw_device d3d11va:{gpu} -hwaccel d3d11va -hwaccel_output_format d3d11 -c:v {SOURCE} -i {video_file} -noautoscale -an -sn -vf "scale=-1:{scale}:format=nv12" -c:v {TARGET} -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark""",
                Source = [
                    (HardwareCodecConfig.h264CodecId, "h264"),
                    (HardwareCodecConfig.hvecCodecId, "hevc"),
                    (HardwareCodecConfig.av1CodecId, "dav1d"),
                ],
                Target = [
                    (HardwareCodecConfig.h264CodecId, "h264_amf"),
                    (HardwareCodecConfig.hvecCodecId, "hevc_amf"),
                    (HardwareCodecConfig.av1CodecId, "av1_amf"),
                ]
             }
            },
            {
             (TestCaseArgumentDeviceType.Intel, [FfmpegVersionConfig.GenericLinuxVersionGroup]),
             new TestCaseGen(){
                Template = """-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -init_hw_device qsv=qs@va -hwaccel qsv -hwaccel_output_format qsv -c:v {SOURCE} -i {video_file} -noautoscale -an -sn -vf "scale_qsv=-1:{scale}:format=nv12" -c:v {TARGET} -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark""",
                Source = [
                    (HardwareCodecConfig.h264CodecId, "h264_qsv"),
                    (HardwareCodecConfig.hvecCodecId, "hevc_qsv"),
                    (HardwareCodecConfig.av1CodecId, "av1_qsv"),
                ],
                Target = [
                    (HardwareCodecConfig.h264CodecId, "h264_qsv"),
                    (HardwareCodecConfig.hvecCodecId, "hevc_qsv"),
                    (HardwareCodecConfig.av1CodecId, "av1_qsv"),
                ]
             }
            },            
        };

        var testCases = new List<TestCaseArgument>();
        foreach (var item in generators)
        {
            foreach (var osGroup in item.Key.ffmpegGroup)
            {
                foreach (var sourceGen in item.Value.Source)
                {
                    foreach (var targetGen in item.Value.Target)
                    {
                        testCases.Add(new TestCaseArgument()
                        {
                            FfmpegArgument = item.Value.Template.Replace("{SOURCE}", sourceGen.type).Replace("{TARGET}", targetGen.type),
                            TestCaseArgumentDeviceType = item.Key.Device,
                            FfmpegVersionGroupId = osGroup,
                            FromHardwareCodecId = sourceGen.codec,
                            ToHardwareCodecId = targetGen.codec,
                        });
                    }
                }
            }
        }

        modelBuilder
            .HasData(testCases.GetWithId());
    }
}
