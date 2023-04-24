///Class used to test mocks of DataReaders.
namespace SQLDataReaderMocks
{
    [TestClass]
    public partial class DataReaderTests
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidCastException))]
        public void Try_Cast_Int16_To_Int32_Wrong_Should_Throw_Exception()
        {
            int? badCast = _systemUnderTest.ReadTranTypeWrongCast();
        }

        [TestMethod]
        public void Try_Cast_Int16_To_Int32_Good_Should_Not_Error()
        {
            int? goodCast = _systemUnderTest.ReadTranType();
            Assert.IsNotNull(goodCast);
            Assert.AreEqual(goodCast, Int16.MaxValue);
        }

    }
}