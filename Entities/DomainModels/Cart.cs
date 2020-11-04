using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Core.Entities.Abstract;

namespace Entities.DomainModels
{
    public class Cart:IDomainModel
    {
        public Cart()
        {
            CartLines= new List<CartLine>();
        }
        public List<CartLine> CartLines { get; set; }

    
    }
}