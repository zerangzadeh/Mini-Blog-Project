namespace MiniBlog.Models
{
    public class Article
    {
        public int ArticleID { get; set; }
        public string Title { get; set; }
        public string ShortDESC { get; set; }
        public string Body { get; set; }
        public string PicTitle { get; set; }
        public string PicALT { get; set; }
        public string PicSrc { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreationDate { get; set; }

        public Article(string title, string shortDESC, string body, string picTitle, string picALT, string picSrc)
        {
          
            Title = title;
            ShortDESC = shortDESC;
            Body = body;
            PicTitle = picTitle;
            PicALT = picALT;
            PicSrc = picSrc;
            IsDeleted = false;
            CreationDate = DateTime.Now;
        }
    }
}
