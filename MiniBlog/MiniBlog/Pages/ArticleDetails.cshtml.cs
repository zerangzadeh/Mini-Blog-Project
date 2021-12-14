using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MiniBlog.Models;

namespace MiniBlog.Pages
{
    public class ArticleDetailsModel : PageModel
    {
        private readonly ArticleContext _articleContext;
        public ArticleViewModel article;

        public ArticleDetailsModel(ArticleContext articleContext)
        {
            _articleContext = articleContext;
        }

        public void OnGet(int id)
        {
            article = _articleContext.Articles.Select(x => new ArticleViewModel
            {
                ArticleID = id,
                Title = x.Title,
                ShortDESC = x.ShortDESC,
                Body = x.Body,
                PicALT = x.PicALT,
                PicSrc = x.PicSrc,
                CreationDate = x.CreationDate.ToString(),

            }).FirstOrDefault(x => x.ArticleID==id);

        }
    }
}
