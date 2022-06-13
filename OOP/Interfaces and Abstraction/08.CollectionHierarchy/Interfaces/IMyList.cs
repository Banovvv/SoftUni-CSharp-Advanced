namespace _08.CollectionHierarchy.Interfaces
{
    public interface IMyList : IAddCollection, IRemoveCollection
    {
        int Used { get; }
    }
}
