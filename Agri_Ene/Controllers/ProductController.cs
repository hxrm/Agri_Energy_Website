using Agri_Ene.Data;
using Agri_Ene.Interface;
using Agri_Ene.Models;
using Agri_Ene.Repository;
using Agri_Ene.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Agri_Ene.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        //Reference to database for "Context"
        private readonly AppDbContext _context;
        //Reference to the Services for the Product
        private readonly IProductRepository _prodRepo;

        //Ctor passes the AppDBContext 
        /* public ProductController(AppDbContext context)
         {
             _context = context;
         }*/
        //Ctor passes through repo and not context 
        public ProductController(IProductRepository prodRepo)
        {

            _prodRepo = prodRepo;           

        }     
        //Shows all the products
        public async Task<IActionResult> Index()//Controller
        {
            //Getting the Model (product)
            // var products = _context.Products.ToList();//Model
            IEnumerable<Product> products = await _prodRepo.GetAll();
            AgriUser farmer = await _prodRepo.GetFarmerDetails();

            ViewData["Farmer"] = farmer;
            //passing and returning with View 
            return View(products);//View
        }
        public async Task<IActionResult> List()//Controller
        {
            //Getting the Model (product)
            // var products = _context.Products.ToList();//Model
            IEnumerable<Product> products = await _prodRepo.GetAll();
            //passing and returning with View 
            return View(products);//View
        }
        public async Task<IActionResult> FilterList()//Controller
        {  // Get all categories for the dropdown
            var categories = Enum.GetValues(typeof(ProductCategories)).Cast<ProductCategories>().ToList();

            // Pass categories to the view
            ViewBag.Categories = categories;

            // Initially, pass all products to the view
            IEnumerable<Product> products = await _prodRepo.GetAll();
            return View(products);
        }
        [HttpPost]
        public async Task<IActionResult> FilterList([FromBody] DateRangeViewModel dateRange)
        {
            DateTime sDate,eDate;
            if (dateRange != null)
            {
                bool isStartDateValid = DateTime.TryParse(dateRange.StartDate, out sDate);
                bool isEndDateValid = DateTime.TryParse(dateRange.EndDate, out eDate);

                if (isStartDateValid && isEndDateValid && sDate != DateTime.MinValue && eDate != DateTime.MinValue)
                {
                   IEnumerable<Product> products = await _prodRepo.GetProductsByDateRange(sDate, eDate);
                    return PartialView("ProductList", products);
                }
            }
            return View();
        }
     
      
        [HttpGet]
        public async Task<IActionResult> GetProductsByCategory(ProductCategories? category, DateTime? startDate, DateTime? endDate)
        {
            var products = await _prodRepo.GetAll();

            if (category.HasValue)
            {
                products = products.Where(p => p.prodCategory == category.Value);
            }

            if (startDate.HasValue && endDate.HasValue)
            {
                products = products.Where(p => p.productionDate >= startDate.Value && p.productionDate <= endDate.Value);
            }

            return PartialView("ProductList", products);
        }

       
        public class DateRangeViewModel
        {
            public string StartDate { get; set; }
            public string EndDate { get; set; }
            public Agri_Ene.Data.ProductCategories? Category { get; set; }

        }

        //Shows a single selected Product
        public async Task<IActionResult> Details(int id)
        {
            var product = await _prodRepo.GetByIdAsync(id);
            (string firstName, string lastName) = await _prodRepo.GetFarmer(product.prodId);
            ViewData["SellerFirstName"] = firstName;
            ViewData["SellerLastName"] = lastName;


            return View(product);

        }
        public IActionResult Create()
        {
            return View();
        }
        //Create the Post Request
        [HttpPost]
        //as in after back from CreateProduct 
        public async Task<IActionResult> Create(Product prod)
        {
            if (!ModelState.IsValid)
            {
                return View(prod);
            }
            _prodRepo.Add(prod);
            return RedirectToAction("Index");
        }

    }
}
