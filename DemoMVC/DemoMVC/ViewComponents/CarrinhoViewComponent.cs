﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;

namespace DemoMVC.ViewComponents
{
    [ViewComponent(Name = "Carrinho")]
    public class CarrinhoViewComponent : ViewComponent
    {
        public int ItensCarrinho { get; set; }

        public CarrinhoViewComponent() 
        {
            ItensCarrinho = 3;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(ItensCarrinho);
        }
    }
}
