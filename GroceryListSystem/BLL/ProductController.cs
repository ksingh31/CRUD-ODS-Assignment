using GroceryListSystem.DAL;
using GroceryListSystem.Data.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryListSystem.BLL
{
    [DataObject]
    public class ProductController
    {
        #region Queries
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<Category> Category_List()
        {
            using (var context = new GroceryListContext())
            {
                return context.Categories.ToList();
            }
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public Category Category_Get(int categoryid)
        {
            using (var context = new GroceryListContext())
            {
                return context.Categories.Find(categoryid);
            }
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<Product> Category_GetProductNames(int categoryid)
        {
            using (var context = new GroceryListContext())
            {
                var results = from x in context.Products
                              where x.CategoryID == categoryid
                              select x;
                return results.ToList();
            }
        }
        #endregion

    }
}
