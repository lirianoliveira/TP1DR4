using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace E8A.Pages
{
    public class IndexModel : PageModel
    {
        

       
        public List<(String Nome, double preco)> Produtos { get; set; }
        public void OnGet()
        {
            Produtos = new List<(string Nome, double preco)>
            {
                ("Uva" , 5.5),
                ("Banana", 3.5),
                ("Laranja", 10)
            };

        }
    }
}
