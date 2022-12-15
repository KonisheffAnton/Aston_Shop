using Aston_Shop.Servises.ProductAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Aston_Shop.Servises.ProductAPI.Controllers
{
    public class HomeController : Controller
    {

        [HttpPost]
        public async Task<ActionResult<Product>> PostTodoItem(Product product)
        {
            DbContext.Products.Add(product);
            await DbContext.SaveChangesAsync();

            //return CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
            return CreatedAtAction(nameof(GetTodoItem), new { id = todoItem.Id }, todoItem);
        }



    }
}
