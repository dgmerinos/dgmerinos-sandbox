namespace MySQLDataReaderStrategy
{
    public interface IDataReaderStrategy
    {
        int ReadTranType();
        int ReadTranTypeWrongCast();
    }
}