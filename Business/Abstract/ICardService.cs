using Entities.Concrete;
using Entities.DomainModels;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICardService
    {
        void AddToCart(Cart cart, Product product);
        void RemoveFromCart(Cart cart, int productId);
        List<CartLine> List(Cart cart);

    }
}