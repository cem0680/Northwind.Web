using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Packt.Shared;

namespace Northwind.Web.Pages;

public class SuppliersModel : PageModel
{

    private NorthwindContext db;
    public SuppliersModel(NorthwindContext injectedContext)
    {
        db = injectedContext;
    }
    public IEnumerable<string>? Suppliers { get; set; }
    public void OnGet()
    {
        ViewData["Title"] = "Northwind B2B - Suppliers";
        Suppliers = (IEnumerable<string>?)db.Suppliers
            .OrderBy(c => c.Country).ThenBy(c => c.CompanyName);
    }

    
}
