using Moq;
using MySQLDataReaderStrategy;
using System.Data;
using System.Data.SqlClient;

namespace SQLDataReaderMocks
{
    public partial class DataReaderTests
    {
        Mock<IDataReader> readerMock;
        Mock<IDataReader> readerMockNull;
        readonly DataReaderStrategy _systemUnderTest;
        readonly DataReaderStrategy _nullReturnSystemUnderTest;
        public DataReaderTests()
        {
            InitializeMocks();
            InitializeMock_GetReturnsNull();
            _systemUnderTest = new DataReaderStrategy(this.readerMock.Object);
            _nullReturnSystemUnderTest = new DataReaderStrategy(this.readerMockNull.Object);
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
