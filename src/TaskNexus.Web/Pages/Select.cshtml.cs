using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection;
using TaskNexus.Web.Services;
using TaskNexus.WebApi;

namespace TaskNexus.Web.Pages
{
    public class SelectModel : PageModel
    {
        private readonly ILogger<SelectModel> _logger;
        private readonly ListProjectService listProjectService;

        public ListProjectDto list { get; set; }

        public static string Value = "";

        public SelectModel(ILogger<SelectModel> logger)
        {
            _logger = logger;
        }

        //public async Task OnGet() {

        //    var value = HttpContext.Session.GetString("Id");
        //    Value = value;

        //    IdDto request = new IdDto();
        //    request.Id = value;

        //    list = await listProjectService.GetList(default, httpContext, request);
            
        //}
    }

}
