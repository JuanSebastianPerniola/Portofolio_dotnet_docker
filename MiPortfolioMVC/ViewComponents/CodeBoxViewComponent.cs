using Microsoft.AspNetCore.Mvc;
using MiPortfolioMVC.Models;

namespace MiPortfolioMVC.ViewComponents
{
    public class CodeBoxViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string title, string code, string language = "csharp")
        {
            var model = new CodeBoxModel
            {
                Title = title,
                Code = code,
                Language = language
            };

            return View(model);
        }
    }
}