namespace Fortius.Domain
{
    public interface IUnitOfWork
    {
        bool IsChanged { get; }

        void ApplyChanges();

        void RejectChanges();
    }
}
