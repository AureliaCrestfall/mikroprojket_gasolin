using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using mikroprojket_gasolin.Model;

namespace mikroprojket_gasolin.Pages
{
    public class memorabiliaModel : PageModel
    {

        private Album[] albumfull = new Album[13];

        private readonly ILogger<memorabiliaModel> _logger;

        public Album[] Albumfulls { get => albumfull; set => albumfull = value; }

        public memorabiliaModel(ILogger<memorabiliaModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

            albumfull[0] = new Album("Gasolin'", "1971", "Gasolin1.png");
            albumfull[1] = new Album("Gasolin' 2", "1972", "Gasolin'_2.jpg");
            albumfull[2] = new Album("Gasolin' 3", "1973", "Gasolin'_3.jpg");
            albumfull[3] = new Album("Gasolin' på englsk", "1974", "Album_Gasolin'_(EN)_cover.jpg");
            albumfull[4] = new Album("Stakkels Jim", "1974", "Gasolin'_4.jpg");
            albumfull[5] = new Album("The last Jim(engslsk)", "1974", "gsaolin4uk.jpg");
            albumfull[6] = new Album("Gas 5", "1975", "gas5.jpg");
            albumfull[7] = new Album("Live sådan", "1976", "Live_Sådan_-_Gasolin'.jpg");
            albumfull[8] = new Album("What a lemon", "1976", "Album_What_a_Lemon_(NL)_cover.jpg");
            albumfull[9] = new Album("Efter endnu en dag", "1976", "Efter_Endnu_en_Dag_-_Gasolin'.jpg");
            albumfull[10] = new Album("Gør det noget", "1977", "gørdetnoget.jpg");
            albumfull[11] = new Album("Killin' Time", "1978", "Killin'_Time_-_Gasolin'.jpg");
            albumfull[12] = new Album("Live i Skandinavien", "1978", "Gøglernes aften.jpg");

        }
    }
}
