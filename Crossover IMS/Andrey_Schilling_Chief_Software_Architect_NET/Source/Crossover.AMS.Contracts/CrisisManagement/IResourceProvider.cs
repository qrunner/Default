namespace Crossover.AMS.Contracts.CrisisManagement
{
    public interface IResourceProvider : IEntity, IContactsProvider
    {
        IResourceCategory ResourceCategory { get; }

        ResourceProviderCategory ProviderCategory { get; }

        string Name { get; }

        bool Available { get; }
    }
}