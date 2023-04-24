using Ardalis.GuardClauses;
using System.Data;
using System.Data.SqlClient;

namespace MySQLDataReaderStrategy
{
    public class DataReaderStrategy : IDataReaderStrategy
    {
        private IDataReader dataReader;

        public DataReaderStrategy()
        {
            
        }
        public DataReaderStrategy(IDataReader dataReader)
        {
            Guard.Against.Null(dataReader, nameof(dataReader));
            this.dataReader = dataReader;
        }

        public int ReadTranType()
        {
            try
            {
                this.dataReader.Read();
                return Convert.ToInt32(dataReader["Treasury_Transac_Type_Id"]);
            }
            catch (Exception ex) { 
                throw new Exception(ex.Message, ex);
            }
        }

        public int ReadTranTypeWrongCast()
        {
            this.dataReader.Read();
            try
            {
                return (int)dataReader["Treasury_Transac_Type_Id"];
            }
            catch (Exception ex)
            {
                throw new InvalidCastException(ex.Message);
            }
           
        }
    }
}