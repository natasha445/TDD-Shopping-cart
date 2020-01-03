using System;
using System.Collections.Generic;
using System.Text;

namespace shoppingCart
{
    public interface iCart
    {
        public bool add(string id, int quantity);
        public object remove(string id);
        public object get(string id);
    }
}
