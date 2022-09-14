using Microsoft.AspNetCore.Mvc;
using MvcRazorViews.ViewModels;

namespace MvcRazorViews.Controllers;

public class EstudanteController : Controller
{
    private static List<EstudanteViewModel> estudantes = new List<EstudanteViewModel> {
        new EstudanteViewModel(1, "José Carlitos", "R. Juá, n.34", true),
        new EstudanteViewModel(2, "João Pedro", "R. Boa, n.51", false),
        new EstudanteViewModel(3, "Marta Francisca", "R. Feliz, n.78", true)
    };

    public IActionResult Index()
    {
        // var estudantesVazia = new List<EstudanteViewModel>();

        return View(estudantes);
    }

    public IActionResult Show(int id)
    {
        return View(estudantes[id-1]);
    }
}