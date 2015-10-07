namespace Accounting
{
    public interface ITransactionManager
    {
        ITransaction StartTransaction();
    }
}
