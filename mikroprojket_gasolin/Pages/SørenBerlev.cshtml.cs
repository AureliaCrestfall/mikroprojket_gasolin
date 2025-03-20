using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;
using mikroprojket_gasolin.Model;

namespace mikroprojket_gasolin.Pages
{
    public class SørenBerlevModel : PageModel
    {
        private Album[] albums2 = new Album[3];

        private readonly ILogger<SørenBerlevModel> _logger;

        public Album[] Albums2 { get => albums2; set => albums2 = value; }
        public SørenBerlevModel(ILogger<SørenBerlevModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            albums2[0] = new Album("Kashmir - The Good Life", "1999", "thegoodlife.jpg");

            albums2[1] = new Album("Kashmir – The Snowman", "2005", "snowman.jpg");

            albums2[2] = new Album("TV-2 – De Første Kærster På Månen", "2005", "månen.jpg");
        }
    }
}
