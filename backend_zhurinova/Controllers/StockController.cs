using backend_zhurinova.Data;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace backend_zhurinova.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/stock")]
    [ApiController]
    public class StockController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        public StockController(ApplicationDBContext context)
        {
            _context = context;
        }
        // GET: api/<StockController>
        [HttpGet]  // Read
        public IActionResult GetAll()
        {
            var stocks = _context.Stocks.ToList();   // ToList() - execution
            return Ok(stocks);
        }

        // GET api/<StockController>/5
        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var stock = _context.Stocks.Find(id);
            if (stock == null)
            {
                return NotFound();
            }
            return Ok(stock);
        }

        // POST api/<StockController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<StockController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StockController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
