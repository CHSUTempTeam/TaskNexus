using Microsoft.AspNetCore.Mvc.RazorPages;
using TaskNexus.Web.Services;
using TaskNexus.WebApi;

namespace TaskNexus.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        private readonly IsLoginService isLoginService;

        public IsLoginDto canLogin { get; set; }

        public IndexModel(ILogger<IndexModel> logger, IsLoginService isLoginService)
        {
            _logger = logger;
            this.isLoginService = isLoginService;
        }

        public async Task OnGet()
        {
            var sett = await isLoginService.GetIsLogin(default);
            canLogin = sett;
        }
    }
}
