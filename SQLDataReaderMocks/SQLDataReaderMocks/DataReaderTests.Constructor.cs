using Moq;
using MySQLDataReaderStrategy;
using System.Data;
using System.Data.SqlClient;

namespace SQLDataReaderMocks
{
    public partial class DataReaderTests
    {
        Mock<IDataReader> readerMock;
        readonly DataReaderStrategy _systemUnderTest;
        public DataReaderTests()
        {
            InitializeMocks();
            _systemUnderTest = new DataReaderStrategy(this.readerMock.Object);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void When_Reader_Null_SQLReaderStrategy_Should_Be_Null()
        {
            SqlDataReader nullReader = null;
            DataReaderStrategy dataReaderStrategy = new(nullReader);
            
        }
    }
}
