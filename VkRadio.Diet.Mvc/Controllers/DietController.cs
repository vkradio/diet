using Microsoft.AspNetCore.Mvc;
using VkRadio.Diet.Mvc.ViewModels.Diet;

namespace VkRadio.Diet.Mvc.Controllers;

public class DietController : Controller
{
    public IActionResult Index()
    {
        throw new NotImplementedException();
    }

    [HttpGet]
    public IActionResult Create()
    {
        throw new NotImplementedException();
    }

    [HttpPost]
    public IActionResult Create(DietEditModel editModel)
    {
        if (ModelState.IsValid)
        {
            throw new NotImplementedException();
        }

        return View(editModel);
    }
}
