using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using MvcWebUI.Helpers;
using MvcWebUI.Models;

namespace MvcWebUI.Controllers
{
    public class CartController:Controller
    {
        private readonly ICardService _cardService;
        private readonly ICartSessionHelper _cartSessionHelper;
        private readonly IProductService _productService;

        public CartController(ICardService cardService, ICartSessionHelper cartSessionHelper, IProductService productService)
        {
            _cardService = cardService;
            _cartSessionHelper = cartSessionHelper;
            _productService = productService;
        }

        public IActionResult AddToCart(int productId)
        {
            //ürünü çek
            Product product = _productService.GetById(productId);

            var cart = _cartSessionHelper.GetCart("cart");
            _cardService.AddToCart(cart,product);
            _cartSessionHelper.SetCart("cart",cart);
            TempData.Add("message", product.ProductName +"item is added to basket" );
            return RedirectToAction($"Index", $"Product");

        }

        public IActionResult RemoveFromCart(int productId)
        {
           Product product = new Product();
           var cart = _cartSessionHelper.GetCart("cart");
           _cardService.RemoveFromCart(cart,productId);
           _cartSessionHelper.SetCart("cart",cart);
           TempData.Add("message",product.ProductName +"item is deleted");
           return RedirectToAction("Index", "Cart");

        }

        public IActionResult Index()
        {
            var model = new CartListViewModel
            {
                Cart = _cartSessionHelper.GetCart("cart")
            };
            return View(model);
        }

        public IActionResult Complete()
        {
            var model = new ShippingDetailsViewModel
            {
                ShippingDetail = new ShippingDetail()
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult Complete(ShippingDetail shippingDetail)
        {
            if (ModelState.IsValid) return View();
            
            
            TempData.Add("message", "Your order is accepted");
                _cartSessionHelper.Clear();
                return RedirectToAction("Index", "Home");

          
        }
    }
}