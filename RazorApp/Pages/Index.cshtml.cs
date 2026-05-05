using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorApp.Models;

namespace RazorApp.Pages
{
    public class IndexModel : PageModel
    {
        public List<string> TaskList { get; set; } = new List<string>();

        public void OnGet()
        {
            TaskList = ItemStore.Items;
        }
    }
}