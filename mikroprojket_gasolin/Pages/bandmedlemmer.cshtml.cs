using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using mikroprojket_gasolin.Model;

namespace mikroprojket_gasolin.Pages
{
    public class bandmedlemmerModel : PageModel
    {

        private bandMember[] member = new bandMember[5];


        private readonly ILogger<bandMember> _logger;

        public bandMember[] Members { get => member; set => member = value; }

        public bandmedlemmerModel(ILogger<bandMember> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Members[0] = new bandMember("Kim Larsen'", "Some text here", "Billede1.jpg", "/KimLarsen");

            Members[1] = new bandMember("Franz Beckerlee' 2", "Some text here", "Gasolin'_2.jpg", "/FranzBeckerlee");

            Members[2] = new bandMember("Wili Jønsson' 3", "Some text here", "Wili.jpg", "/WiliJønsson");
            Members[3] = new bandMember("Bjørn Uglebjerg' 4", "Some text here", "Gasolin'_4.jpg", "/BjørnUglebjerg");
            Members[4] = new bandMember("Søren Berlev' 4", "Some text here", "Søren.jpg", "/SørenBerlev");

        }
    }
}
