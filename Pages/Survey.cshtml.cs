using Microsoft.AspNetCore.Mvc.RazorPages;

namespace prelab5.Pages
{
    public class SurveyModel : PageModel
    {
        public string[] Hobbies { get; } = new string[] { "drawing", "driving", "programming", "listening to music" };
    }
}