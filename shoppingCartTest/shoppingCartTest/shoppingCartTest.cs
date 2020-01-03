using System;
using System.Collections.Generic;
using shoppingCart;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace shoppingCartTest
{
    [TestClass]
    public class shoppingCartTest
    {
        [TestMethod]
        public void test_add_data_to_list()
        {
            var product = new Dictionary<string, int>();
            var cart = new cart(product);

            string id = "pear";
            int quantity = 10;

            cart.add(id, quantity);

            Assert.IsTrue(product.Count == 1);
            Assert.AreEqual(product[id], quantity);
        }

        [TestMethod]
        public void test_return_false_if_id_is_null()
        {
            var product = new Dictionary<string, int>();
            var cart = new cart(product);

            string id = null;
            int quantity = 10;

            cart.add(id, quantity);

            Assert.IsTrue(product.Count == 0);
        }

        [TestMethod]
        public void test_return_false_if_quantity_is_equal_or_less_than_0()
        {
            var product = new Dictionary<string, int>();
            var cart = new cart(product);

            string id = "pear";
            int quantity = 0;

            cart.add(id, quantity);

            Assert.IsTrue(product.Count == 0);
        }
        
        [TestMethod]
        public void test_remove_return_false_if_item_is_not_in_list()
        {
            var product = new Dictionary<string, int>();
            var cart = new cart(product);

            string id = "pear";
            int quantity = 10;

            product.Add(id, quantity);

            Assert.AreEqual(cart.get(id), quantity);
            Assert.IsNull(cart.remove("wrong ID"));
        }

        [TestMethod]
        public void test_get_return_false_if_id_is_not_in_list()
        {
            var product = new Dictionary<string, int>();
            var cart = new cart(product);

            string id = "pear";
            int quantity = 10;

            product.Add(id, quantity);

            Assert.AreEqual(cart.get(id), quantity);
            Assert.IsNull(cart.get("wrong ID"));
        }
    }
}