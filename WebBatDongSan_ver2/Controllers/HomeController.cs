using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using PagedList.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebBatDongSan_ver2.Helpers;
using WebBatDongSan_ver2.Models;

namespace WebBatDongSan_ver2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]

        public IActionResult Index(int? page)
        {
            BatDongSan_DBContext _context = new BatDongSan_DBContext();
            ViewData["DienTich"] = new SelectList(_context.Areas, "Id", "Name");
            ViewData["Loai"] = new SelectList(_context.BusinessTypes, "Id", "Name");
            ViewData["KhoangGia"] = new SelectList(_context.Prices, "Id", "PriceRange");
            ViewData["KhuVuc"] = new SelectList(_context.Addresses, "Id", "AddressName");

            // TẠO PHÂN TRANG CHO INDEX
            var pageNumber = page == null || page <= 0 ? 1 : page.Value;
            var pageSize = Utilities.PAGE_SIZE;//20
            var Isproducts = _context.Products;
            PagedList<Product> models = new PagedList<Product>(Isproducts, pageNumber, pageSize);
            ViewBag.CurrentPage = pageNumber;
            return View(models);
        }

        [HttpPost]
        public IActionResult Index(int? page, string searchString = "", string addressString = "", string areaString = "", string bTypeString = "", string priceString = "")
        {

            BatDongSan_DBContext _context = new BatDongSan_DBContext();
            var IsProduct = _context.Products.ToList();
            //DropdownList Search
            ViewData["DienTich"] = new SelectList(_context.Areas, "Id", "Name");
            ViewData["Loai"] = new SelectList(_context.BusinessTypes, "Id", "Name");
            ViewData["KhoangGia"] = new SelectList(_context.Prices, "Id", "PriceRange");
            ViewData["KhuVuc"] = new SelectList(_context.Addresses, "Id", "AddressName");
            //Search here
            if (addressString != null)
            {
                IsProduct = _context.Products.Where(x => x.Description.Contains(addressString)).ToList();
            }

            //

            else if (areaString != null)
            {
                var areaRange = _context.Areas.Where(x => x.Id == Int32.Parse(areaString)).FirstOrDefault();
                var min = areaRange.MinValue;
                var max = areaRange.MaxValue;
                IsProduct = _context.Products.Where(x => x.Acreage >= min && x.Acreage <= max).ToList();
            }

            //
            else if (bTypeString != null)
            {
                IsProduct = _context.Products.Where(x => x.CatagoryId == (Int32.Parse(bTypeString))).ToList();
            }

            //
            else if (priceString != null)
            {
                var priceRange = _context.Prices.Where(x => x.Id == Int32.Parse(priceString)).FirstOrDefault();
                var min = priceRange.MinValue;
                var max = priceRange.Maxvalue;

                IsProduct = _context.Products.Where(x => x.Price >= min && x.Price <= max).ToList();
            }

            // TẠO PHÂN TRANG CHO INDEX
            var pageNumber = page == null || page <= 0 ? 1 : page.Value;
            var pageSize = Utilities.PAGE_SIZE;//20
             PagedList<Product> models = new PagedList<Product>(IsProduct.AsQueryable(), pageNumber, pageSize);
             ViewBag.CurrentPage = pageNumber;
            return View(models);
        }

        public IActionResult Detail(int id)
        {
            //get list product
            BatDongSan_DBContext _context = new BatDongSan_DBContext();

            var detailProducts = _context.Products.Where(x => x.Id == id).FirstOrDefault();
            return View(detailProducts);



        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
