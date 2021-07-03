
using System.Collections.Generic;

namespace R_Store
{
    public interface IProduct_Repository
    {
        Product[] GetAllByTitle(string titlePart);
        Product GetById(int id);
        Product[] GetAllByIds(IEnumerable<int> productIds);
    }
}
