using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorTour.Pages;

public class IndexModel : PageModel
{
     public string []Animal={"Dog","Cat"," Mouse"};

    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }
     [BindProperty]
        public string UserInput { get; set; }  // Property to bind form data

        public string Message { get; set; }
        public string Announce;
        // This method runs when the form is submitted (POST request)
        public void OnPost()
        {
            // Process the input data here (e.g., save to database, etc.)
            Message = $"You entered: {UserInput}";
        }
    public void OnGet()
    {
Announce="bajanda";
    }
}
