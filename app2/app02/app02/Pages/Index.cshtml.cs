using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace app02.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public float Value { get; set; }
        public float Result;

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Value = 0;
            
        }
        public void OnPost()
        {
            Result = ((float)(Value * 1.15));
        }
    }
}