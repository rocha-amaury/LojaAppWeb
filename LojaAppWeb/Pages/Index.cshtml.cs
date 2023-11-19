﻿using LojaAppWeb.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LojaAppWeb.Pages;

public class IndexModel : PageModel
{

    public IList<Produto> ListaProdutos { get; set; }

    public void OnGet()
    {
        ViewData["Title"] = "Home page";

        ListaProdutos = new List<Produto>()
        {
            new Produto
            {
                ProdutoId = 1,
                Nome = "Ancho Intermezzo",
                Descricao = "Ancho Intermezzo",
                ImagemUri= "/images/01_ancho_intermezzo.webp",
                Preco =19.00,
                EntregaExpressa= true,
                DataCadastro = DateTime.Now
            },
            
            new Produto
            {
                ProdutoId = 2,
                Nome = "Prime Rib Bassi Marfrig",
                Descricao = "Prime Rib Bassi Marfrig",
                ImagemUri= "/images/02_prime_rib_bassi_marfrig.webp",
                Preco =29.00,
                EntregaExpressa= false,
                DataCadastro = DateTime.Now
            },
            
            new Produto
            {
                ProdutoId = 3,
                Nome = "Ancho Bassi Marfrig",
                Descricao = "Ancho Bassi Marfrig",
                ImagemUri= "/images/01_ancho_intermezzo.webp",
                Preco =22.00,
                EntregaExpressa= true,
                DataCadastro = DateTime.Now
            },
            
            new Produto
            {
                ProdutoId = 4,
                Nome = "T-Bone Intermezzo",
                Descricao = "T-Bone Intermezzo",
                ImagemUri= "/images/01_ancho_intermezzo.webp",
                Preco =25.00,
                EntregaExpressa= false,
                DataCadastro = DateTime.Now
            },


            //05 - Shoulder Black VPJ
            //06 - Flat Iron Intermezzo
            //07 - Chuck Steak Intermezzo
            //08 - Prime Rib Bassi Marfrig
            //09 - Maminha Bassi Marfrig
            //10 - Tomahawk Cara Preta

        };
    }    

}