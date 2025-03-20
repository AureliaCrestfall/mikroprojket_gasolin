namespace mikroprojket_gasolin.Model
{
    public class bandMember
    {
        public string Name { get; set; }
        public string Text { get; set; }
        public string ImagePath { get; set; }
        public string LinkPath { get; set; }



        public bandMember(string name, string year, string imagePath, string dlink)
        {
            Name = name;
            Text = year;
            ImagePath = imagePath;
            LinkPath = dlink;
        }
    }
}
