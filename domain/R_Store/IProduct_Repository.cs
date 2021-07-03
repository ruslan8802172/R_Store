
namespace R_Store
{
    public interface IProduct_Repository
    {
        Product[] GetAllByTitle(string titlePart);
        Product GetById(int id);
    }
}
