namespace mikroprojket_gasolin.Model
{
    public class Album
    {
        public string Name { get; set; }
        public string Year { get; set; }
        public string ImagePath { get; set; }
        

        
        public Album(string name, string year, string imagePath)
        {
            Name = name;
            Year = year;
            ImagePath = imagePath;
        }
    }
}
