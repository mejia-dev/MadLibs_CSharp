using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Form() { return View(); }

    [Route("/madLib")]
    public ActionResult MadLib(string Name1, string Number1, string Adjective1, string Color1, string Noun1, string FoodPlural1, string Noun2, string Verb1, string Clothing1, string Adjective2, string Celebrity1, string Number2, string Name2, string Noun3, string Name3, string Occupation1) 
    { 
      FormVariable newFormVariable = new FormVariable();
      newFormVariable.Name1 = Name1;
      newFormVariable.Number1 = Number1;
      newFormVariable.Adjective1 = Adjective1;
      newFormVariable.Color1 = Color1;
      newFormVariable.Noun1 = Noun1;
      newFormVariable.FoodPlural1 = FoodPlural1;
      newFormVariable.Noun2 = Noun2;
      newFormVariable.Verb1 = Verb1;
      newFormVariable.Clothing1 = Clothing1; 
      newFormVariable.Adjective2 = Adjective2;
      newFormVariable.Celebrity1 = Celebrity1;
      newFormVariable.Number2 = Number2;
      newFormVariable.Name2 = Name2;
      newFormVariable.Noun3 = Noun3;
      newFormVariable.Name3 = Name3;
      newFormVariable.Occupation1 = Occupation1;
      return View(newFormVariable);
    }
  }
}