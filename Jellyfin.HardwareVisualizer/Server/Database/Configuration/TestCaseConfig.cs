using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Jellyfin.HardwareVisualizer.Server.Database.Configuration;

public class TestCaseConfig : IEntityTypeConfiguration<TestCase>
{
    public void Configure(EntityTypeBuilder<TestCase> modelBuilder)
    {
        modelBuilder
            .HasData(new TestCase[]
            {
				#region File E8A75E65-A3F3-4D92-A45B-84E71A13EFAB	
				new TestCase()
                {

                    MediaTestFileId = new Guid("E8A75E65-A3F3-4D92-A45B-84E71A13EFAB"),
                    TestCaseType = TestCaseType.Transcode,
                    FromResolution = "2160p",
                    ToResolution = "2160p",
                    Bitrate = 79616000,
                    ToCodecId  = HardwareCodecConfig.h264CodecId
                },
                new TestCase()
                {

                    MediaTestFileId = new Guid("E8A75E65-A3F3-4D92-A45B-84E71A13EFAB"),
                    TestCaseType = TestCaseType.Transcode,
                    FromResolution = "2160p",
                    ToResolution = "1080p",
                    Bitrate = 9616000,
                    ToCodecId  = HardwareCodecConfig.h264CodecId
                },
                new TestCase()
                {

                    MediaTestFileId = new Guid("E8A75E65-A3F3-4D92-A45B-84E71A13EFAB"),
                    TestCaseType = TestCaseType.Transcode,
                    FromResolution = "2160p",
                    ToResolution = "720p",
                    Bitrate = 3616000,
                    ToCodecId  = HardwareCodecConfig.h264CodecId
                },
                new TestCase()
                {

                    MediaTestFileId = new Guid("E8A75E65-A3F3-4D92-A45B-84E71A13EFAB"),
                    TestCaseType = TestCaseType.Transcode,
                    FromResolution = "1080p",
                    ToResolution = "2160p",
                    Bitrate = 79616000,
                    ToCodecId  = HardwareCodecConfig.h264CodecId
                },
                new TestCase()
                {

                    MediaTestFileId = new Guid("E8A75E65-A3F3-4D92-A45B-84E71A13EFAB"),
                    TestCaseType = TestCaseType.Transcode,
                    FromResolution = "1080p",
                    ToResolution = "1080p",
                    Bitrate = 9616000,
                    ToCodecId  = HardwareCodecConfig.h264CodecId
                },
                new TestCase()
                {

                    MediaTestFileId = new Guid("E8A75E65-A3F3-4D92-A45B-84E71A13EFAB"),
                    TestCaseType = TestCaseType.Transcode,
                    FromResolution = "1080p",
                    ToResolution = "720p",
                    Bitrate = 3616000,
                    ToCodecId  = HardwareCodecConfig.h264CodecId
                },
                new TestCase()
                {

                    MediaTestFileId = new Guid("E8A75E65-A3F3-4D92-A45B-84E71A13EFAB"),
                    TestCaseType = TestCaseType.Transcode,
                    FromResolution = "720p",
                    ToResolution = "2160p",
                    Bitrate = 79616000,
                    ToCodecId  = HardwareCodecConfig.h264CodecId
                },
                new TestCase()
                {

                    MediaTestFileId = new Guid("E8A75E65-A3F3-4D92-A45B-84E71A13EFAB"),
                    TestCaseType = TestCaseType.Transcode,
                    FromResolution = "720p",
                    ToResolution = "1080p",
                    Bitrate = 9616000,
                    ToCodecId  = HardwareCodecConfig.h264CodecId
                },
                new TestCase()
                {

                    MediaTestFileId = new Guid("E8A75E65-A3F3-4D92-A45B-84E71A13EFAB"),
                    TestCaseType = TestCaseType.Transcode,
                    FromResolution = "720p",
                    ToResolution = "720p",
                    Bitrate = 3616000,
                    ToCodecId  = HardwareCodecConfig.h264CodecId
                },

                new TestCase()
                {

                    MediaTestFileId = new Guid("E8A75E65-A3F3-4D92-A45B-84E71A13EFAB"),
                    TestCaseType = TestCaseType.Transcode,
                    FromResolution = "2160p",
                    ToResolution = "2160p",
                    Bitrate = 79616000,
                    ToCodecId  = HardwareCodecConfig.hvecCodecId
                },
                new TestCase()
                {

                    MediaTestFileId = new Guid("E8A75E65-A3F3-4D92-A45B-84E71A13EFAB"),
                    TestCaseType = TestCaseType.Transcode,
                    FromResolution = "2160p",
                    ToResolution = "1080p",
                    Bitrate = 9616000,
                    ToCodecId  = HardwareCodecConfig.hvecCodecId
                },
                new TestCase()
                {

                    MediaTestFileId = new Guid("E8A75E65-A3F3-4D92-A45B-84E71A13EFAB"),
                    TestCaseType = TestCaseType.Transcode,
                    FromResolution = "2160p",
                    ToResolution = "720p",
                    Bitrate = 3616000,
                    ToCodecId  = HardwareCodecConfig.hvecCodecId
                },
                new TestCase()
                {

                    MediaTestFileId = new Guid("E8A75E65-A3F3-4D92-A45B-84E71A13EFAB"),
                    TestCaseType = TestCaseType.Transcode,
                    FromResolution = "1080p",
                    ToResolution = "2160p",
                    Bitrate = 79616000,
                    ToCodecId  = HardwareCodecConfig.hvecCodecId
                },
                new TestCase()
                {

                    MediaTestFileId = new Guid("E8A75E65-A3F3-4D92-A45B-84E71A13EFAB"),
                    TestCaseType = TestCaseType.Transcode,
                    FromResolution = "1080p",
                    ToResolution = "1080p",
                    Bitrate = 9616000,
                    ToCodecId  = HardwareCodecConfig.hvecCodecId
                },
                new TestCase()
                {

                    MediaTestFileId = new Guid("E8A75E65-A3F3-4D92-A45B-84E71A13EFAB"),
                    TestCaseType = TestCaseType.Transcode,
                    FromResolution = "1080p",
                    ToResolution = "720p",
                    Bitrate = 3616000,
                    ToCodecId  = HardwareCodecConfig.hvecCodecId
                },
                new TestCase()
                {

                    MediaTestFileId = new Guid("E8A75E65-A3F3-4D92-A45B-84E71A13EFAB"),
                    TestCaseType = TestCaseType.Transcode,
                    FromResolution = "720p",
                    ToResolution = "2160p",
                    Bitrate = 79616000,
                    ToCodecId  = HardwareCodecConfig.hvecCodecId
                },
                new TestCase()
                {

                    MediaTestFileId = new Guid("E8A75E65-A3F3-4D92-A45B-84E71A13EFAB"),
                    TestCaseType = TestCaseType.Transcode,
                    FromResolution = "720p",
                    ToResolution = "1080p",
                    Bitrate = 9616000,
                    ToCodecId  = HardwareCodecConfig.hvecCodecId
                },
                new TestCase()
                {

                    MediaTestFileId = new Guid("E8A75E65-A3F3-4D92-A45B-84E71A13EFAB"),
                    TestCaseType = TestCaseType.Transcode,
                    FromResolution = "720p",
                    ToResolution = "720p",
                    Bitrate = 3616000,
                    ToCodecId  = HardwareCodecConfig.hvecCodecId
                },

				#endregion

				#region File E1E58B15-6664-454C-868A-20442DB30557
				
				new TestCase()
                {

                    MediaTestFileId = new Guid("E1E58B15-6664-454C-868A-20442DB30557"),
                    TestCaseType = TestCaseType.Transcode,
                    FromResolution = "2160p",
                    ToResolution = "2160p",
                    Bitrate = 79616000,
                    ToCodecId  = HardwareCodecConfig.h264CodecId
                },
                new TestCase()
                {

                    MediaTestFileId = new Guid("E1E58B15-6664-454C-868A-20442DB30557"),
                    TestCaseType = TestCaseType.Transcode,
                    FromResolution = "2160p",
                    ToResolution = "1080p",
                    Bitrate = 9616000,
                    ToCodecId  = HardwareCodecConfig.h264CodecId
                },
                new TestCase()
                {

                    MediaTestFileId = new Guid("E1E58B15-6664-454C-868A-20442DB30557"),
                    TestCaseType = TestCaseType.Transcode,
                    FromResolution = "2160p",
                    ToResolution = "720p",
                    Bitrate = 3616000,
                    ToCodecId  = HardwareCodecConfig.h264CodecId
                },
                new TestCase()
                {

                    MediaTestFileId = new Guid("E1E58B15-6664-454C-868A-20442DB30557"),
                    TestCaseType = TestCaseType.Transcode,
                    FromResolution = "1080p",
                    ToResolution = "2160p",
                    Bitrate = 79616000,
                    ToCodecId  = HardwareCodecConfig.h264CodecId
                },
                new TestCase()
                {

                    MediaTestFileId = new Guid("E1E58B15-6664-454C-868A-20442DB30557"),
                    TestCaseType = TestCaseType.Transcode,
                    FromResolution = "1080p",
                    ToResolution = "1080p",
                    Bitrate = 9616000,
                    ToCodecId  = HardwareCodecConfig.h264CodecId
                },
                new TestCase()
                {

                    MediaTestFileId = new Guid("E1E58B15-6664-454C-868A-20442DB30557"),
                    TestCaseType = TestCaseType.Transcode,
                    FromResolution = "1080p",
                    ToResolution = "720p",
                    Bitrate = 3616000,
                    ToCodecId  = HardwareCodecConfig.h264CodecId
                },
                new TestCase()
                {

                    MediaTestFileId = new Guid("E1E58B15-6664-454C-868A-20442DB30557"),
                    TestCaseType = TestCaseType.Transcode,
                    FromResolution = "720p",
                    ToResolution = "2160p",
                    Bitrate = 79616000,
                    ToCodecId  = HardwareCodecConfig.h264CodecId
                },
                new TestCase()
                {

                    MediaTestFileId = new Guid("E1E58B15-6664-454C-868A-20442DB30557"),
                    TestCaseType = TestCaseType.Transcode,
                    FromResolution = "720p",
                    ToResolution = "1080p",
                    Bitrate = 9616000,
                    ToCodecId  = HardwareCodecConfig.h264CodecId
                },
                new TestCase()
                {

                    MediaTestFileId = new Guid("E1E58B15-6664-454C-868A-20442DB30557"),
                    TestCaseType = TestCaseType.Transcode,
                    FromResolution = "720p",
                    ToResolution = "720p",
                    Bitrate = 3616000,
                    ToCodecId  = HardwareCodecConfig.h264CodecId
                },





                new TestCase()
                {

                    MediaTestFileId = new Guid("E1E58B15-6664-454C-868A-20442DB30557"),
                    TestCaseType = TestCaseType.Transcode,
                    FromResolution = "2160p",
                    ToResolution = "2160p",
                    Bitrate = 79616000,
                    ToCodecId  = HardwareCodecConfig.hvecCodecId
                },
                new TestCase()
                {

                    MediaTestFileId = new Guid("E1E58B15-6664-454C-868A-20442DB30557"),
                    TestCaseType = TestCaseType.Transcode,
                    FromResolution = "2160p",
                    ToResolution = "1080p",
                    Bitrate = 9616000,
                    ToCodecId  = HardwareCodecConfig.hvecCodecId
                },
                new TestCase()
                {

                    MediaTestFileId = new Guid("E1E58B15-6664-454C-868A-20442DB30557"),
                    TestCaseType = TestCaseType.Transcode,
                    FromResolution = "2160p",
                    ToResolution = "720p",
                    Bitrate = 3616000,
                    ToCodecId  = HardwareCodecConfig.hvecCodecId
                },
                new TestCase()
                {

                    MediaTestFileId = new Guid("E1E58B15-6664-454C-868A-20442DB30557"),
                    TestCaseType = TestCaseType.Transcode,
                    FromResolution = "1080p",
                    ToResolution = "2160p",
                    Bitrate = 79616000,
                    ToCodecId  = HardwareCodecConfig.hvecCodecId
                },
                new TestCase()
                {

                    MediaTestFileId = new Guid("E1E58B15-6664-454C-868A-20442DB30557"),
                    TestCaseType = TestCaseType.Transcode,
                    FromResolution = "1080p",
                    ToResolution = "1080p",
                    Bitrate = 9616000,
                    ToCodecId  = HardwareCodecConfig.hvecCodecId
                },
                new TestCase()
                {

                    MediaTestFileId = new Guid("E1E58B15-6664-454C-868A-20442DB30557"),
                    TestCaseType = TestCaseType.Transcode,
                    FromResolution = "1080p",
                    ToResolution = "720p",
                    Bitrate = 3616000,
                    ToCodecId  = HardwareCodecConfig.hvecCodecId
                },
                new TestCase()
                {

                    MediaTestFileId = new Guid("E1E58B15-6664-454C-868A-20442DB30557"),
                    TestCaseType = TestCaseType.Transcode,
                    FromResolution = "720p",
                    ToResolution = "2160p",
                    Bitrate = 79616000,
                    ToCodecId  = HardwareCodecConfig.hvecCodecId
                },
                new TestCase()
                {

                    MediaTestFileId = new Guid("E1E58B15-6664-454C-868A-20442DB30557"),
                    TestCaseType = TestCaseType.Transcode,
                    FromResolution = "720p",
                    ToResolution = "1080p",
                    Bitrate = 9616000,
                    ToCodecId  = HardwareCodecConfig.hvecCodecId
                },
                new TestCase()
                {

                    MediaTestFileId = new Guid("E1E58B15-6664-454C-868A-20442DB30557"),
                    TestCaseType = TestCaseType.Transcode,
                    FromResolution = "720p",
                    ToResolution = "720p",
                    Bitrate = 3616000,
                    ToCodecId  = HardwareCodecConfig.hvecCodecId
                },
				#endregion

				#region File 70DAEBE7-C9FC-4E02-A524-2FC825A49355
		
				new TestCase()
                {

                    MediaTestFileId = new Guid("70DAEBE7-C9FC-4E02-A524-2FC825A49355"),
                    TestCaseType = TestCaseType.Transcode,
                    FromResolution = "2160p",
                    ToResolution = "2160p",
                    Bitrate = 79616000,
                    ToCodecId  = HardwareCodecConfig.h264CodecId
                },
                new TestCase()
                {

                    MediaTestFileId = new Guid("70DAEBE7-C9FC-4E02-A524-2FC825A49355"),
                    TestCaseType = TestCaseType.Transcode,
                    FromResolution = "2160p",
                    ToResolution = "1080p",
                    Bitrate = 9616000,
                    ToCodecId  = HardwareCodecConfig.h264CodecId
                },
                new TestCase()
                {

                    MediaTestFileId = new Guid("70DAEBE7-C9FC-4E02-A524-2FC825A49355"),
                    TestCaseType = TestCaseType.Transcode,
                    FromResolution = "2160p",
                    ToResolution = "720p",
                    Bitrate = 3616000,
                    ToCodecId  = HardwareCodecConfig.h264CodecId
                },
                new TestCase()
                {

                    MediaTestFileId = new Guid("70DAEBE7-C9FC-4E02-A524-2FC825A49355"),
                    TestCaseType = TestCaseType.Transcode,
                    FromResolution = "1080p",
                    ToResolution = "2160p",
                    Bitrate = 79616000,
                    ToCodecId  = HardwareCodecConfig.h264CodecId
                },
                new TestCase()
                {

                    MediaTestFileId = new Guid("70DAEBE7-C9FC-4E02-A524-2FC825A49355"),
                    TestCaseType = TestCaseType.Transcode,
                    FromResolution = "1080p",
                    ToResolution = "1080p",
                    Bitrate = 9616000,
                    ToCodecId  = HardwareCodecConfig.h264CodecId
                },
                new TestCase()
                {

                    MediaTestFileId = new Guid("70DAEBE7-C9FC-4E02-A524-2FC825A49355"),
                    TestCaseType = TestCaseType.Transcode,
                    FromResolution = "1080p",
                    ToResolution = "720p",
                    Bitrate = 3616000,
                    ToCodecId  = HardwareCodecConfig.h264CodecId
                },
                new TestCase()
                {

                    MediaTestFileId = new Guid("70DAEBE7-C9FC-4E02-A524-2FC825A49355"),
                    TestCaseType = TestCaseType.Transcode,
                    FromResolution = "720p",
                    ToResolution = "2160p",
                    Bitrate = 79616000,
                    ToCodecId  = HardwareCodecConfig.h264CodecId
                },
                new TestCase()
                {

                    MediaTestFileId = new Guid("70DAEBE7-C9FC-4E02-A524-2FC825A49355"),
                    TestCaseType = TestCaseType.Transcode,
                    FromResolution = "720p",
                    ToResolution = "1080p",
                    Bitrate = 9616000,
                    ToCodecId  = HardwareCodecConfig.h264CodecId
                },
                new TestCase()
                {

                    MediaTestFileId = new Guid("70DAEBE7-C9FC-4E02-A524-2FC825A49355"),
                    TestCaseType = TestCaseType.Transcode,
                    FromResolution = "720p",
                    ToResolution = "720p",
                    Bitrate = 3616000,
                    ToCodecId  = HardwareCodecConfig.h264CodecId
                },

                new TestCase()
                {

                    MediaTestFileId = new Guid("70DAEBE7-C9FC-4E02-A524-2FC825A49355"),
                    TestCaseType = TestCaseType.Transcode,
                    FromResolution = "2160p",
                    ToResolution = "2160p",
                    Bitrate = 79616000,
                    ToCodecId  = HardwareCodecConfig.hvecCodecId
                },
                new TestCase()
                {

                    MediaTestFileId = new Guid("70DAEBE7-C9FC-4E02-A524-2FC825A49355"),
                    TestCaseType = TestCaseType.Transcode,
                    FromResolution = "2160p",
                    ToResolution = "1080p",
                    Bitrate = 9616000,
                    ToCodecId  = HardwareCodecConfig.hvecCodecId
                },
                new TestCase()
                {

                    MediaTestFileId = new Guid("70DAEBE7-C9FC-4E02-A524-2FC825A49355"),
                    TestCaseType = TestCaseType.Transcode,
                    FromResolution = "2160p",
                    ToResolution = "720p",
                    Bitrate = 3616000,
                    ToCodecId  = HardwareCodecConfig.hvecCodecId
                },
                new TestCase()
                {

                    MediaTestFileId = new Guid("70DAEBE7-C9FC-4E02-A524-2FC825A49355"),
                    TestCaseType = TestCaseType.Transcode,
                    FromResolution = "1080p",
                    ToResolution = "2160p",
                    Bitrate = 79616000,
                    ToCodecId  = HardwareCodecConfig.hvecCodecId
                },
                new TestCase()
                {

                    MediaTestFileId = new Guid("70DAEBE7-C9FC-4E02-A524-2FC825A49355"),
                    TestCaseType = TestCaseType.Transcode,
                    FromResolution = "1080p",
                    ToResolution = "1080p",
                    Bitrate = 9616000,
                    ToCodecId  = HardwareCodecConfig.hvecCodecId
                },
                new TestCase()
                {

                    MediaTestFileId = new Guid("70DAEBE7-C9FC-4E02-A524-2FC825A49355"),
                    TestCaseType = TestCaseType.Transcode,
                    FromResolution = "1080p",
                    ToResolution = "720p",
                    Bitrate = 3616000,
                    ToCodecId  = HardwareCodecConfig.hvecCodecId
                },
                new TestCase()
                {

                    MediaTestFileId = new Guid("70DAEBE7-C9FC-4E02-A524-2FC825A49355"),
                    TestCaseType = TestCaseType.Transcode,
                    FromResolution = "720p",
                    ToResolution = "2160p",
                    Bitrate = 79616000,
                    ToCodecId  = HardwareCodecConfig.hvecCodecId
                },
                new TestCase()
                {

                    MediaTestFileId = new Guid("70DAEBE7-C9FC-4E02-A524-2FC825A49355"),
                    TestCaseType = TestCaseType.Transcode,
                    FromResolution = "720p",
                    ToResolution = "1080p",
                    Bitrate = 9616000,
                    ToCodecId  = HardwareCodecConfig.hvecCodecId
                },
                new TestCase()
                {

                    MediaTestFileId = new Guid("70DAEBE7-C9FC-4E02-A524-2FC825A49355"),
                    TestCaseType = TestCaseType.Transcode,
                    FromResolution = "720p",
                    ToResolution = "720p",
                    Bitrate = 3616000,
                    ToCodecId  = HardwareCodecConfig.hvecCodecId
                },

				#endregion
				#region File 1D943D13-586D-4562-A968-EB1D0FFAE947
				
				new TestCase()
                {

                    MediaTestFileId = new Guid("1D943D13-586D-4562-A968-EB1D0FFAE947"),
                    TestCaseType = TestCaseType.Transcode,
                    FromResolution = "2160p",
                    ToResolution = "2160p",
                    Bitrate = 79616000,
                    ToCodecId  = HardwareCodecConfig.h264CodecId
                },
                new TestCase()
                {

                    MediaTestFileId = new Guid("1D943D13-586D-4562-A968-EB1D0FFAE947"),
                    TestCaseType = TestCaseType.Transcode,
                    FromResolution = "2160p",
                    ToResolution = "1080p",
                    Bitrate = 9616000,
                    ToCodecId  = HardwareCodecConfig.h264CodecId
                },
                new TestCase()
                {

                    MediaTestFileId = new Guid("1D943D13-586D-4562-A968-EB1D0FFAE947"),
                    TestCaseType = TestCaseType.Transcode,
                    FromResolution = "2160p",
                    ToResolution = "720p",
                    Bitrate = 3616000,
                    ToCodecId  = HardwareCodecConfig.h264CodecId
                },
                new TestCase()
                {

                    MediaTestFileId = new Guid("1D943D13-586D-4562-A968-EB1D0FFAE947"),
                    TestCaseType = TestCaseType.Transcode,
                    FromResolution = "1080p",
                    ToResolution = "2160p",
                    Bitrate = 79616000,
                    ToCodecId  = HardwareCodecConfig.h264CodecId
                },
                new TestCase()
                {

                    MediaTestFileId = new Guid("1D943D13-586D-4562-A968-EB1D0FFAE947"),
                    TestCaseType = TestCaseType.Transcode,
                    FromResolution = "1080p",
                    ToResolution = "1080p",
                    Bitrate = 9616000,
                    ToCodecId  = HardwareCodecConfig.h264CodecId
                },
                new TestCase()
                {

                    MediaTestFileId = new Guid("1D943D13-586D-4562-A968-EB1D0FFAE947"),
                    TestCaseType = TestCaseType.Transcode,
                    FromResolution = "1080p",
                    ToResolution = "720p",
                    Bitrate = 3616000,
                    ToCodecId  = HardwareCodecConfig.h264CodecId
                },
                new TestCase()
                {

                    MediaTestFileId = new Guid("1D943D13-586D-4562-A968-EB1D0FFAE947"),
                    TestCaseType = TestCaseType.Transcode,
                    FromResolution = "720p",
                    ToResolution = "2160p",
                    Bitrate = 79616000,
                    ToCodecId  = HardwareCodecConfig.h264CodecId
                },
                new TestCase()
                {

                    MediaTestFileId = new Guid("1D943D13-586D-4562-A968-EB1D0FFAE947"),
                    TestCaseType = TestCaseType.Transcode,
                    FromResolution = "720p",
                    ToResolution = "1080p",
                    Bitrate = 9616000,
                    ToCodecId  = HardwareCodecConfig.h264CodecId
                },
                new TestCase()
                {

                    MediaTestFileId = new Guid("1D943D13-586D-4562-A968-EB1D0FFAE947"),
                    TestCaseType = TestCaseType.Transcode,
                    FromResolution = "720p",
                    ToResolution = "720p",
                    Bitrate = 3616000,
                    ToCodecId  = HardwareCodecConfig.h264CodecId
                },

                new TestCase()
                {

                    MediaTestFileId = new Guid("1D943D13-586D-4562-A968-EB1D0FFAE947"),
                    TestCaseType = TestCaseType.Transcode,
                    FromResolution = "2160p",
                    ToResolution = "2160p",
                    Bitrate = 79616000,
                    ToCodecId  = HardwareCodecConfig.hvecCodecId
                },
                new TestCase()
                {

                    MediaTestFileId = new Guid("1D943D13-586D-4562-A968-EB1D0FFAE947"),
                    TestCaseType = TestCaseType.Transcode,
                    FromResolution = "2160p",
                    ToResolution = "1080p",
                    Bitrate = 9616000,
                    ToCodecId  = HardwareCodecConfig.hvecCodecId
                },
                new TestCase()
                {

                    MediaTestFileId = new Guid("1D943D13-586D-4562-A968-EB1D0FFAE947"),
                    TestCaseType = TestCaseType.Transcode,
                    FromResolution = "2160p",
                    ToResolution = "720p",
                    Bitrate = 3616000,
                    ToCodecId  = HardwareCodecConfig.hvecCodecId
                },
                new TestCase()
                {

                    MediaTestFileId = new Guid("1D943D13-586D-4562-A968-EB1D0FFAE947"),
                    TestCaseType = TestCaseType.Transcode,
                    FromResolution = "1080p",
                    ToResolution = "2160p",
                    Bitrate = 79616000,
                    ToCodecId  = HardwareCodecConfig.hvecCodecId
                },
                new TestCase()
                {

                    MediaTestFileId = new Guid("1D943D13-586D-4562-A968-EB1D0FFAE947"),
                    TestCaseType = TestCaseType.Transcode,
                    FromResolution = "1080p",
                    ToResolution = "1080p",
                    Bitrate = 9616000,
                    ToCodecId  = HardwareCodecConfig.hvecCodecId
                },
                new TestCase()
                {

                    MediaTestFileId = new Guid("1D943D13-586D-4562-A968-EB1D0FFAE947"),
                    TestCaseType = TestCaseType.Transcode,
                    FromResolution = "1080p",
                    ToResolution = "720p",
                    Bitrate = 3616000,
                    ToCodecId  = HardwareCodecConfig.hvecCodecId
                },
                new TestCase()
                {

                    MediaTestFileId = new Guid("1D943D13-586D-4562-A968-EB1D0FFAE947"),
                    TestCaseType = TestCaseType.Transcode,
                    FromResolution = "720p",
                    ToResolution = "2160p",
                    Bitrate = 79616000,
                    ToCodecId  = HardwareCodecConfig.hvecCodecId
                },
                new TestCase()
                {

                    MediaTestFileId = new Guid("1D943D13-586D-4562-A968-EB1D0FFAE947"),
                    TestCaseType = TestCaseType.Transcode,
                    FromResolution = "720p",
                    ToResolution = "1080p",
                    Bitrate = 9616000,
                    ToCodecId  = HardwareCodecConfig.hvecCodecId
                },
                new TestCase()
                {

                    MediaTestFileId = new Guid("1D943D13-586D-4562-A968-EB1D0FFAE947"),
                    TestCaseType = TestCaseType.Transcode,
                    FromResolution = "720p",
                    ToResolution = "720p",
                    Bitrate = 3616000,
                    ToCodecId  = HardwareCodecConfig.hvecCodecId
                },
				#endregion
			}.GetWithId());
    }
}
