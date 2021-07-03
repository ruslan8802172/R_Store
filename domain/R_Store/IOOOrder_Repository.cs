using System;
using System.Collections.Generic;
using System.Text;

namespace R_Store
{
    public interface IOOOrder_Repository
    {
        Order Create();

        Order GetById(int id);

        void Update(Order order);
    }
}
