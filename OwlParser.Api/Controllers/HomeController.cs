using Microsoft.AspNetCore.Mvc;
using OwlParser.Api.Models;

namespace OwlParser.Api.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            HomeModel model = new();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Index(HomeModel model)
        {
            try
            {
                if (model.OwlFile == null)
                    throw new Exception("Nenhum arquivo foi selecionado");

                var fileContent = await ReadFileContent(model.OwlFile);
                Lib.Parser parser = new(fileContent);
                model.BpmnXmlString = parser.ToBpmnString().First();

                return View(model);
            }
            catch (Exception ex)
            {
                model.ExceptionMessage = ex.Message;
                return View(model);
            }
        }

        private async Task<string> ReadFileContent(IFormFile file)
        {
            using var stream = file.OpenReadStream();
            using var reader = new StreamReader(stream);
            return await reader.ReadToEndAsync();
        }
    }
}