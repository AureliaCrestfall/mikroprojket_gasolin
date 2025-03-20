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
            Members[0] = new bandMember("Kim Larsen", "Forsanger og rytmeguitarist", "Billede1.jpg", "/KimLarsen");

            Members[1] = new bandMember("Franz Beckerlee", "Leadguitarist og lejlighedsvis saxofonist", "Franz.jpg", "/FranzBeckerlee");

            Members[2] = new bandMember("Wili Jønsson", "Bassist, keyboardspiller og med på backingvokal", "Wili.jpg", "/WiliJønsson");
            Members[3] = new bandMember("Søren Berlev", "Trommeslager og percussionist", "Søren.jpg", "/SørenBerlev");
            Members[4] = new bandMember("Bjørn Uglebjerg", "Original trommeslager", "Bjørn.png", "/BjørnUglebjerg");

        }
    }
}
