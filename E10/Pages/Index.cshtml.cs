using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace E10.Pages
{
    public class IndexModel : PageModel
    {

        [BindProperty]
        public string nome { get; set; }
        [BindProperty]
        public double preco { get; set; }

        public bool Enviar { get; set; } = false;

        public class Produto
        {
            public string nome { get; set; }
            public double preco { get; set; }
        }

        public static List<Produto> ListaProdutos = new List<Produto>();
        public void OnGet()
        {

        }

        public void OnPost()

        {
            if (!string.IsNullOrEmpty(nome))
            {
                ListaProdutos.Add(new Produto { nome = nome, preco = preco });

            }
     
        }
    }
}

