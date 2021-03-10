using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RestaurantSystem.Data;
using RestaurantSystem.Models;
using RestaurantSystem.ViewModel;

namespace RestaurantSystem.Views.Orders
{
    public class OrdersController : Controller
    {
        private readonly RestaurantSystemContext _context;

        public OrdersController(RestaurantSystemContext context)
        {
            _context = context;
        }

        // GET: Orders
        public async Task<IActionResult> Index()
        {
            var restaurantSystemContext = _context.Order.Include(o => o.Customer).Include(o => o.Employee);
            return View(await restaurantSystemContext.ToListAsync());
        }

        //Find out if customer already in system 
        //GET THE phone Number INFORMATION
        public IActionResult FindCustomer()
        {
           
            return View();
        }


        // Check if the phone number is in the system.  
        // If YES, there is already a customer ID.  Send it to create an order 
        // If NO, then send to create a a new customer
        
        [HttpPost]
        public IActionResult FindCustomer(String PhoneNumber)
        {

            if (ModelState.IsValid)
            {
                Customer myCustomer = _context.Customer.Where(x => x.PhoneNumber == PhoneNumber).FirstOrDefault();
                if (myCustomer == null)
                {
                    return Redirect("/Customers/Create");
                }
                else
                {
                    return Redirect("/Orders/Add/"+ myCustomer.ID);
                }

            }
            else
            {
                return View();
            }
            
        }



        // GET: Orders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Order
                .Include(o => o.Customer)
                .Include(o => o.Employee)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // GET: Orders/Create
        public IActionResult Create()
        {
            ViewData["CustomerID"] = new SelectList(_context.Customer, "ID", "Address");
            ViewData["EmployeeID"] = new SelectList(_context.Employee, "ID", "LastName");
            return View();
        }


        // POST: 
        // Get a customer 
        // Load the customer details and product details
        // Load the view model with all the information
        [HttpPost]
        public IActionResult Add(AddOrderViewModel addOrderViewModel)
        {
            Order myOrder = new Order()
            {
                EmployeeID=2,
                CustomerID = addOrderViewModel.CustomerID,
                OrderReceivedDate = addOrderViewModel.OrderReceivedDate,
                OrderProducts = new List<OrderProduct>(),
        };
            foreach (string ProductID in addOrderViewModel.CustomerSelectedProduct)
            {
                Product myItem = _context.Products.Where(x => x.ID == Int32.Parse(ProductID)).FirstOrDefault();
                myOrder.OrderProducts.Add(myItem);
            }


            _context.Add(myOrder);
            _context.SaveChanges();


            return Redirect("/");
        }

        // GET: 
        // Get a customer 
        // Load the customer details and product details
        // Load the view model with all the information
        [Route("Orders/Add/{CustomerID}")]
        [HttpGet]
        public IActionResult Add(int CustomerID)
        {
            Customer myCustomer = _context.Customer.Where(x => x.ID == CustomerID).FirstOrDefault();
            if (myCustomer == null)
            {
                return Redirect("/Orders/FindCustomer");
            }
            else
            {
                AddOrderViewModel myOrder = new AddOrderViewModel();
                myOrder.Products = _context.Products.ToList();
                myOrder.Customer = myCustomer;
                return View(myOrder);
            }

        }

        // POST: Orders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,CustomerID,EmployeeID,OrderReceivedDate,OrderTipAmount")] Order order)
        {
            if (ModelState.IsValid)
            {
                _context.Add(order);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CustomerID"] = new SelectList(_context.Customer, "ID", "Address", order.CustomerID);
            ViewData["EmployeeID"] = new SelectList(_context.Employee, "ID", "LastName", order.EmployeeID);
            return View(order);
        }

        // GET: Orders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Order.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }
            ViewData["CustomerID"] = new SelectList(_context.Customer, "ID", "Address", order.CustomerID);
            ViewData["EmployeeID"] = new SelectList(_context.Employee, "ID", "LastName", order.EmployeeID);
            return View(order);
        }

        // POST: Orders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,CustomerID,EmployeeID,OrderReceivedDate,OrderTipAmount")] Order order)
        {
            if (id != order.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(order);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderExists(order.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CustomerID"] = new SelectList(_context.Customer, "ID", "Address", order.CustomerID);
            ViewData["EmployeeID"] = new SelectList(_context.Employee, "ID", "LastName", order.EmployeeID);
            return View(order);
        }

        // GET: Orders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Order
                .Include(o => o.Customer)
                .Include(o => o.Employee)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // POST: Orders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var order = await _context.Order.FindAsync(id);
            _context.Order.Remove(order);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrderExists(int id)
        {
            return _context.Order.Any(e => e.ID == id);
        }
    }
}
