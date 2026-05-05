using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorApp.Models;

namespace RazorApp.Pages
{
    public class AddModel : PageModel
    {
        [BindProperty]
        public string NewItem { get; set; } = "";

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!string.IsNullOrEmpty(NewItem))
            {
                ItemStore.Items.Add(NewItem);
            }
            return RedirectToPage("/Index");
        }
    }
}