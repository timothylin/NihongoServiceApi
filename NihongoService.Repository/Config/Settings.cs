namespace NihongoService.Repository.Config
{
    using System.Configuration;

    public static class Settings
    {
        private static string _connectionString;

        public static string ConnectionString
        {
            get
            {
                if (string.IsNullOrEmpty(_connectionString))
                {
                    _connectionString = ConfigurationManager.ConnectionStrings["NihongoRepository"].ConnectionString;
                }

                return _connectionString;
            }
        }
    }
}
