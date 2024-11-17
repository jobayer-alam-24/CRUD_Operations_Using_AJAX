using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace CRUD_Operations_Using_AJAX.Controllers
{
    public class TransactionController : Controller
    {
        private readonly TransactionDbContext _CONTEXT;

        public TransactionController(TransactionDbContext  context)
        {
            _CONTEXT = context;
        }
        //Get Transaction
        public async Task<IActionResult> Index()
        {
            return View(await _CONTEXT.Transactions.ToListAsync());
        }
        //Add or Edit - Get
        public async Task<IActionResult> AddOrEdit(int? id = 0)
        {
            if(id == 0)
                return View();
            else
            {
                var transaction = await _CONTEXT.Transactions.FindAsync(id);
                if(transaction == null) return NotFound();
            
                return View(transaction);
            }
        }
        //Post Transaction
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id", "AccountNumber", "BeneficiaryName", "BankName", "SWIFT_Code", "Amount")] Transaction transaction)
        {
            if(ModelState.IsValid)
            {
                _CONTEXT.Add(transaction);
                await _CONTEXT.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(transaction);
        }
        //Edit Transaction Get
        public async Task<IActionResult> Edit(int? id)
        {
            if(id == null) return NotFound();
            var transaction = await _CONTEXT.Transactions.FindAsync(id);
            if(transaction == null) return NotFound();
            
            return View(transaction);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if(id == null) return NotFound();
            var transaction = await _CONTEXT.Transactions.FindAsync(id);
            if(transaction == null) return NotFound();

            return View(transaction);
        }
        
        //Get Details Transaction
        /*public async Task<IActionResult> Details(int? id)
        {
            if(id == null) return NotFound();
            var transaction = await _CONTEXT.Transactions.FindAsync(id);
            if(transaction == null) return NotFound();

            else return View(transaction);
        }
        */

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}