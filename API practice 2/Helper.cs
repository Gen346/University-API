namespace API_practice_2
{
    public class Helper
    {
        private readonly IConfiguration _configuration;

        public Helper(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string CnnVal(string name)
        {
            return _configuration.GetConnectionString(name) ?? throw new ArgumentException($"Connection string '{name}' not found.");
        }
    }
}
