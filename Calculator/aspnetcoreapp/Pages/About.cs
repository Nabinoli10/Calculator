using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace aspnetcoreapp.Pages;

public class AboutModel : PageModel
{
    private readonly ILogger<AboutModel> _logger;

    public AboutModel(ILogger<AboutModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
    public void OnPost()
    {
 
        if (Request.Method.Equals("POST", System.StringComparison.OrdinalIgnoreCase)){
 
            if(Request.Form["+"]=="+"){
 
                ViewData["sum"]= "Answer" + (double.Parse(Request.Form["num1"])+double.Parse(Request.Form["num2"]));
 
            }

 
            if(Request.Form["^2"]=="^2"){
 
                ViewData["squares"]="Answer" + (double.Parse(Request.Form["num1"]) * double.Parse(Request.Form["num1"]));
 
            }

            if(Request.Form["^"]=="^"){
 
                ViewData["power"]="Answer" + (Math.Pow(double.Parse(Request.Form["num1"]),double.Parse(Request.Form["num2"])));
 
            }

             if(Request.Form["*"]=="*"){
 
                ViewData["multiply"]="Answer" + (double.Parse(Request.Form["num1"])*double.Parse(Request.Form["num2"]));
 
            }

            if(Request.Form["-"]=="-"){
 
                ViewData["subtrct"]="Answer" + (double.Parse(Request.Form["num1"]) - double.Parse(Request.Form["num2"]));
 
            }
             if(Request.Form["/"]=="/"){
 
                ViewData["divison"]= double.Parse(Request.Form["num1"]) / double.Parse(Request.Form["num2"]);
 
            }
             if(Request.Form["^3"]=="^3"){
 
                ViewData["cube"]= double.Parse(Request.Form["num1"]) * double.Parse(Request.Form["num1"])*double.Parse(Request.Form["num1"]);
 
            }


        }
 
 
    }
}