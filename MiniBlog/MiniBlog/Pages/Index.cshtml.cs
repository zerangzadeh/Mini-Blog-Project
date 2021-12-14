using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MiniBlog.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ArticleContext _articleContext;
        public List<ArticleViewModel> articles;

        public IndexModel(ArticleContext articleContext)
        {
            _articleContext = articleContext;
            articles = new List<ArticleViewModel>();
        }

        public void OnGet()
        {
            articles = _articleContext.Articles.Where(x=>x.IsDeleted==false).Select(x => new ArticleViewModel()
            {
                ArticleID = x.ArticleID,
                Title = x.Title,
                ShortDESC = x.ShortDESC,
                Body = x.Body,
                PicTitle = x.PicTitle,
                PicALT = x.PicALT,
                PicSrc = x.PicSrc,
            }).OrderByDescending(x => x.ArticleID).ToList();




        }

        public IActionResult OnGetDelete(int id)
        {
            var articleForDel = _articleContext.Articles.FirstOrDefault(x => x.ArticleID == id);
            articleForDel.IsDeleted = true;
            _articleContext.SaveChanges();
            return RedirectToAction("./Index");
        }
    }
}
