using System.Collections;
using System.Collections.Generic;
using Entities.Concrete;

namespace MvcWebUI.Models
{
    public class CategoryListViewModel 
    {
        
        public List<Category> Categories;
        public int CurrentCategory { get; set; }
    }
}