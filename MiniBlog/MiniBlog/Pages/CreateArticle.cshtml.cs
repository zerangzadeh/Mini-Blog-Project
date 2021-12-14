using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MiniBlog.Models;

namespace MiniBlog.Pages
{
    public class CreateArticleModel : PageModel

    {   
        
        public ArticleForCreate command { get; set; }
        [TempData]
        public string ErrorMessage { get; set; }
        [TempData]
        public string SuccessMessage { get; set; }

        
        private readonly ArticleContext _articleContext;

        public CreateArticleModel(ArticleContext articleContext)
        {
            _articleContext = articleContext;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost(ArticleForCreate command)
        {
            if (ModelState.IsValid)
           {
                var article = new Article(command.Title, command.ShortDESC, command.Body, command.PicTitle, command.PicALT, "~/images/" + command.PicSrc);
                _articleContext.Articles.Add(article);
                _articleContext.SaveChanges();
                return RedirectToPage("./Index");
           }
           else
          {
                ErrorMessage = "لطفا مقادیر خواسته شده را تکمیل نمایید.";
                return Page();
           }
           
        }
    }
}
