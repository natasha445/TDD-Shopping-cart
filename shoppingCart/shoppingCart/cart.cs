using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace shoppingCart
{
    public class cart : iCart
    {
        private IDictionary<string, int> product;
        public cart(IDictionary<string, int> _product = null)
        {
            if (_product == null) _product = new Dictionary<string, int>();

            product = _product;
        }

        public bool add(string id, int quantity)
        {
            if (id != null && quantity > 0)
            {
                product.Add(id, quantity);
                return true;
            }
            else
            {
                return false;
            }
        }

        public object remove(string id)
        {
            if (id == null)
            {
                return null;
            }
            else
            {
                if (!product.ContainsKey(id))
                {
                    return null;
                }
                else
                {
                    var result = product[id];
                    product.Remove(id);
                    return result;
                }
            }
        }

        public object get(string id)
        {
            if (id != null && product.ContainsKey(id))
            {
                return product[id];
            }
            else
            {
                return null;
            }
        }
    }
}