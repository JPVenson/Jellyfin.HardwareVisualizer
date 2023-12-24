namespace Jellyfin.HardwareVisualizer.Shared;

public class TranscodeSubmission
{
	public Hwinfo hwinfo { get; set; }
	public ICollection<CodecTest> tests { get; set; }
}