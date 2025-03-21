namespace mikroprojket_gasolin.Model
{
    public class AlbumTime
    {
        public string Name { get; set; }
        public string Year { get; set; }
        public string ImagePath { get; set; }
        public DateTime Old { get; set; }




        public AlbumTime(string name, string year, string imagePath)
        {
            Name = name;
            Year = year;
            ImagePath = imagePath;
        }
        public AlbumTime(string name, string year, string imagePath, DateTime old):this( name,  year,  imagePath)
        {
            Old = old;
        }
    }
}
