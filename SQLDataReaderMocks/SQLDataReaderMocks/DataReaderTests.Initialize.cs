using Moq;
using System.Data;
using System.Data.SqlClient;

namespace SQLDataReaderMocks
{
    public partial class DataReaderTests
    {
        
        void InitializeMocks()
        {
            readerMock = new Mock<IDataReader>();
            readerMock.SetupSequence(x => x.Read())
                .Returns(true)
                .Returns(false);
            readerMock.SetupGet<object>(x => x["Treasury_Transac_Type_Id"]).Returns(Int16.MaxValue);
        }

        void InitializeMock_GetReturnsNull()
        {
            readerMockNull = new Mock<IDataReader>();
            readerMockNull.SetupSequence(x => x.Read())
                .Returns(true)
                .Returns(false);
            readerMockNull.SetupGet<object>(x => x["Treasury_Transac_Type_Id"]).Returns(null);
        }
    }
}
