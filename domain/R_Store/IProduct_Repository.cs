using System;
using System.Collections.Generic;
using System.Text;

namespace R_Store
{
    public interface IProduct_Repository
    {
        Product[] GetAllByTitle(string titlePart); 

    }
}
