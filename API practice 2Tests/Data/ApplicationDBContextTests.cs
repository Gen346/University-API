namespace API_practice_2.Data.Tests
{
    [TestClass()]
    public class ApplicationDBContextTests
    {
        [TestMethod()]
        public void ConnectionStringIsCorrect()
        {
            ApplicationDBContext dBContext = new ApplicationDBContext();
            string dbConnectionString = dBContext.connectionString;
            string correctConnectionString = "Server = 38.180.138.70; Database = University;User Id = root; Password = G8P8v46P74; Encrypt = True; TrustServerCertificate = True";
            Assert.AreEqual(correctConnectionString,  dbConnectionString);
        }
    }
}