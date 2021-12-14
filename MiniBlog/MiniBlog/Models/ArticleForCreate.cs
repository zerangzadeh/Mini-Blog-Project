using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

public class ArticleForCreate
{
    [DisplayName("عنوان مقاله")]
    [Required(ErrorMessage = "عنوان مقاله اجباری است")]
    public string Title { get; set; }
    [DisplayName("خلاصه")]
    [Required(ErrorMessage = "توضیحات کوتاه مقاله اجباری است")]
    public string ShortDESC { get; set; }
    [DisplayName("متن مقاله")]
    [Required(ErrorMessage = "متن مقاله اجباری است")]
    public string Body { get; set; }
    [DisplayName("عنوان تصویر")]
    [Required(ErrorMessage = "عنوان تصویر اجباری است")]
    public string PicTitle { get; set; }
    [DisplayName("ALT تصویر")]
    public string PicALT { get; set; }
    [DisplayName("مسیر تصویر")]
    [Required(ErrorMessage = "عکس مقاله اجباری است")]
    public string PicSrc { get; set; }
     
}
