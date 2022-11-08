using Microsoft.AspNetCore.Mvc;
using TypeOfFlowers.Models;


namespace TypeOfFlowers.Controllers
{
    public class TypeOfFlowersController : Controller
    {
        private static List<TypesViewModel> types= new List<TypesViewModel>();
        public IActionResult Index()
        {

            return View(types);

        }

        public IActionResult Type()
        {
            var typeVm = new TypesViewModel();
            return View(typeVm);
        }



        public IActionResult RegisterType(TypesViewModel typesViewModel)
        {
            types.Add(typesViewModel);
            return RedirectToAction(nameof(Index));
        }


    }
}




