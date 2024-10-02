using System.Security.Cryptography;

namespace Jellyfin.HardwareVisualizer.Server.Database.Configuration;

public static class IdGenerator
{
    public static TestCaseArgument GetWithId(this TestCaseArgument testCaseArgument)
    {
        return testCaseArgument with
        {
            Id = new Guid(Get16BitHash(testCaseArgument.GetHashCode()))
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
            Id = new Guid(Get16BitHash(testCase.GetHashCode()))
        };
    }

    public static IEnumerable<TestCase> GetWithId(this IEnumerable<TestCase> testCaseArgument)
    {
        return testCaseArgument.Select(GetWithId);
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
