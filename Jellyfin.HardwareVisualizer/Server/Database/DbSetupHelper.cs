namespace Jellyfin.HardwareVisualizer.Server.Database;

public static class DbSetupHelper
{
    public static void SetupDbIfNotExist(string postgreSqlConnectionString)
    {
        NpgsqlConnectionStringBuilder connBuilder = new()
        {
            ConnectionString = postgreSqlConnectionString
        };

        string dbName = connBuilder.Database;

        var masterConnection = postgreSqlConnectionString.Replace(dbName, "postgres");

        using (NpgsqlConnection connection = new(masterConnection))
        {
            connection.Open();
            using var checkIfExistsCommand = new NpgsqlCommand($"SELECT 1 FROM pg_catalog.pg_database WHERE datname = '{dbName}'", connection);
            var result = checkIfExistsCommand.ExecuteScalar();

            if (result == null)
            {
                using var command = new NpgsqlCommand($"CREATE DATABASE \"{dbName}\"", connection);
                command.ExecuteNonQuery();
            }
        }
    }
}