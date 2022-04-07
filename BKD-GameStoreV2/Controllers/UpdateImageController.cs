using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BKD_GameStoreV2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UpdateImageController : ControllerBase
    {


        private readonly ApplicationDbContext _context;
        public UpdateImageController(ApplicationDbContext context)
        {
            _context = context;
        }



        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var product = await _context.Products.FindAsync(id);
                if (product == null)
                {
                    return NotFound();
                }
                System.IO.File.Delete(product.image);
                return Ok(new { message = "delete image successfull" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }



        /*
                         System.IO.File.Delete(product.image);
                await _context.SaveChangesAsync();
         */
    }
}
