using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;
using mikroprojket_gasolin.Model;

namespace mikroprojket_gasolin.Pages
{
    public class KimLarsenModel : PageModel
    {

        private Album[] albums = new Album[4];


        private readonly ILogger<KimLarsenModel> _logger;

        public Album[] Albums { get => albums; set => albums = value; }

        public KimLarsenModel(ILogger<KimLarsenModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            albums[0] = new Album("Gasolin'", "1971", "Gasolin1.png");

            albums[1] = new Album("Gasolin' 2", "1973", "Gasolin'_2.jpg");

            albums[2] = new Album("Gasolin' 3", "1975", "Gasolin'_3.jpg");
            albums[3] = new Album("Gasolin' 4", "1978", "Gasolin'_4.jpg");

        }
    }
}
