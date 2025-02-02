using System.Security.Cryptography;
using System.Text;

namespace Jellyfin.HardwareVisualizer.Server.Database.Configuration;

public static class IdGenerator
{
    public static TestCaseArgument GetWithId(this TestCaseArgument testCaseArgument)
    {
        return testCaseArgument with
        {
            Id = new Guid(Get16BitHash(testCaseArgument.FfmpegArgument.ToUpper() + 
                testCaseArgument.FromHardwareCodecId +
                testCaseArgument.ToHardwareCodecId +
                testCaseArgument.FfmpegVersionGroupId))
        };
    }

    public static IEnumerable<TestCaseArgument> GetWithId(this IEnumerable<TestCaseArgument> testCaseArgument)
    {
        return testCaseArgument.Select(GetWithId);
    }

    public static TestCase GetWithId(this TestCase testCase)
    {
        return testCase with
        {
            Id = new Guid(Get16BitHash(testCase.ToString()))
        };
    }

    public static IEnumerable<TestCase> GetWithId(this IEnumerable<TestCase> testCaseArgument)
    {
        return testCaseArgument.Select(GetWithId);
    }

    public static byte[] Get16BitHash(string input)
    {
        using (var md5Hasher = MD5.Create())
        {
            var data = md5Hasher.ComputeHash(Encoding.UTF8.GetBytes(input));

            var target = new byte[16];
            for (int i = 0; i < data.Length; i++)
            {
                target[i % 16] |= data[i];
            }
            return target;
        }
    }

    public static byte[] Get16BitHash(int input)
    {
        using (var md5Hasher = MD5.Create())
        {
            var data = md5Hasher.ComputeHash(BitConverter.GetBytes(input));

            var target = new byte[16];
            for (int i = 0; i < data.Length; i++)
            {
                target[i % 16] |= data[i];
            }
            return target;
        }
    }
}
