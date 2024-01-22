using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Homepage() { return View(); }

    [Route("/story1form")]
    public ActionResult Story1Form() { return View(); }

    [Route("/story2form")]
    public ActionResult Story2Form() { return View(); }

    [Route("/story1")]
    public ActionResult Story1(string Adjective1, string Noun1, string Adjective2, string NounPlace, string Adjective3, string Adjective4, string VehiclePlural1, string Adjective5, string Adjective6, string NounPlural1, string Adjective7, string NounPlural2, string NounPlural3, string Adjective8, string NounPlural4, string Verb2, string Adjective9, string Verb3, string NounPlural5, string Adjective10, string NounPluralTypeOfJob, string Verb4, string Adjective11)
    {
      Story1FormVariable newFormVariable = new Story1FormVariable();
      newFormVariable.Adjective1 = Adjective1;
      newFormVariable.Noun1 = Noun1;
      newFormVariable.Adjective2 = Adjective2;
      newFormVariable.NounPlace = NounPlace;
      newFormVariable.Adjective3 = Adjective3;
      newFormVariable.Adjective4 = Adjective4;
      newFormVariable.VehiclePlural1 = VehiclePlural1;
      newFormVariable.Adjective5 = Adjective5;
      newFormVariable.Adjective6 = Adjective6;
      newFormVariable.NounPlural1 = NounPlural1;
      newFormVariable.Adjective7 = Adjective7;
      newFormVariable.NounPlural2 = NounPlural2;
      newFormVariable.NounPlural3 = NounPlural3;
      newFormVariable.Adjective8 = Adjective8;
      newFormVariable.NounPlural4 = NounPlural4;
      newFormVariable.Verb2 = Verb2;
      newFormVariable.Adjective9 = Adjective9;
      newFormVariable.Verb3 = Verb3;
      newFormVariable.NounPlural5 = NounPlural5;
      newFormVariable.Adjective10 = Adjective10;
      newFormVariable.NounPluralTypeOfJob = NounPluralTypeOfJob;
      newFormVariable.Verb4 = Verb4;
      newFormVariable.Adjective11 = Adjective11;
      return View(newFormVariable);
    }
    [Route("/story2")]
    public ActionResult Story2(string Name1, string Number1, string Adjective1, string Color1, string Noun1, string FoodPlural1, string Noun2, string Verb1, string Clothing1, string Adjective2, string Celebrity1, string Number2, string Name2, string Noun3, string Name3, string Occupation1) 
    { 
      Story2FormVariable newFormVariable = new Story2FormVariable();
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