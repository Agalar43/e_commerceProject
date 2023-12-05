namespace Repositories.Contracts
{
    public interface IRepositoriesBase<T>
    {
        IQueryable<T> FindAll(bool trackChanges);
    }
}