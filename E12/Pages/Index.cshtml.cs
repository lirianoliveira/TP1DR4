using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace E12.Pages
{
    public class IndexModel : PageModel
    {
        public class Event
        {
            public string Titulo { get; set; }
            public DateTime Date { get; set; }
            public string Local {  get; set; }
        }
        [BindProperty]
        public Event NovoE {  get; set; }

        public Action<Event> OnEventCriacao = (e) =>
        {
            Console.WriteLine($"Evento: {e.Titulo} - Data: {e.Date} - Local: {e.Local}");
};
        public void OnGet()
        {

        }
        public void OnPost()
        {
            if (!string.IsNullOrEmpty( NovoE.Titulo ))
            {
                OnEventCriacao(NovoE);
            }
        }
    }
}
