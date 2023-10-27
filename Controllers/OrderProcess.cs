﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
//impot linq
using System.Linq;
namespace BookShoppingCartMVC.Controllers
{
    public class OrderProcess : Controller
    {
        private readonly ApplicationDbContext _context;
        public OrderProcess(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            

            //select o.Id, u.UserName, o.CreateDate, o.OrderStatusId, o.IsDeleted from Order_HE176084 o join AspNetUsers_HE176084 u on o.UserID = u.Id
            var orders = (from o in _context.Orders
                          join u in _context.Users on o.UserID equals u.Id
                          join os in _context.OrderStatus on o.OrderStatusId equals os.Id
                         select new OrderUserView
                                                                            {
                              Id = o.Id,
                              UserName = u.UserName,
                              CreateDate = o.CreateDate,
                              StatusName = os.StatusName,
                              IsDeleted = o.IsDeleted
                          }).ToList();
            ViewBag.Orders = orders;
            return View();
        }
        //View Order Details
        public IActionResult Details(int id)
        {
            var rs = _context.OrderDetails.Where(x => x.OrderId == id)
                .Include(x => x.Book)
                .ThenInclude(x => x.Genre)
                .ToList();
            ViewBag.OrderId = id;
            return View(rs);
        }   
        //Edit Order Status
        public IActionResult Edit(int id)
        {
            var order = _context.Orders.Find(id);
            ViewBag.UserID = _context.Users.Find(order.UserID).Id;
            ViewBag.UserName = _context.Users.Find(order.UserID).UserName;
            ViewData["OrderStatusId"] = new SelectList(_context.OrderStatus, "Id", "StatusName");
            return View(order);
        }
        [HttpPost]
        public IActionResult Edit(Order order)
        {

                _context.Orders.Update(order);
                _context.SaveChanges();
                return RedirectToAction("Index");
     
        }   
        
    }
}
