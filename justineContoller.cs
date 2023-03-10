using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using jupiterApp.Models;

namespace jupiterApp.Controllers;

public class JupiterController : Controller
{
    public IActionResult index(){
        return View();
    }
    public IActionResult index1(){
        return View();
    }
    public IActionResult index2(){
        return View();
    }
}

