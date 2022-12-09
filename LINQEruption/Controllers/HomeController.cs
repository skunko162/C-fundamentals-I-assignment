using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using LINQEruption.Models;

namespace LINQEruption.Controllers;

public class HomeController : Controller
{

public static Eruption[] AllEruptions = new Eruption[]
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46, "Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};
public IActionResult Index()
{
    Eruption? Chile = AllEruptions.FirstOrDefault(eruption => eruption.Location == "Chile");
    ViewBag.Chile = Chile;
    

    Eruption? Hawaiian = AllEruptions.FirstOrDefault(h => h.Location == "Hawaiian Is");
    ViewBag.Hawaiian = Hawaiian;
    
    Eruption? GreenLand = AllEruptions.FirstOrDefault(h => h.Location == "Greenland");
    ViewBag.GreenLand = GreenLand;

    Eruption? NZ = AllEruptions.Where(eruption => eruption.Location == "New Zealand").FirstOrDefault(y => y.Year > 1900);
    ViewBag.NZ = NZ;

    List<Eruption> Elevation = AllEruptions.Where(e => e.ElevationInMeters > 2000).ToList();
    ViewBag.Elevation = Elevation;

    List<Eruption> Volcano = AllEruptions.Where(e => e.Volcano.StartsWith("L")).ToList();
    ViewBag.Volcano=Volcano;

    int? MaxElevation = AllEruptions.Max(m => m.ElevationInMeters);
    ViewBag.MaxElevation = MaxElevation;

    Eruption? TallestVolcano = AllEruptions.FirstOrDefault(e => e.ElevationInMeters == MaxElevation);
    ViewBag.TallestVolcano =TallestVolcano;

    List<string> AlphaVol = AllEruptions.OrderBy(v=> v.Volcano).Select(s => s.Volcano).ToList();
    ViewBag.AlphaVol = AlphaVol; 

    int? TotalHeight = AllEruptions.Sum(a => a.ElevationInMeters);
    ViewBag.TotalHeight = TotalHeight;

    bool AnyMil = AllEruptions.Any(e => e.Year ==2000);
    ViewBag.AnyMil = AnyMil;

    List<Eruption> StratVol = AllEruptions.Where(v => v.Type == "Stratovolcano").Take(3).ToList();
    ViewBag.StratVol = StratVol;

    List<Eruption> AncientVol = AllEruptions.Where(y => y.Year < 1000).OrderBy(v => v.Volcano).ToList();
    ViewBag.AncientVol = AncientVol;

    List<string> AncientList = AllEruptions.Where(y => y.Year < 1000).Select(v => v.Volcano).ToList();
    ViewBag.AncientList = AncientList;
    return View();
}
}

