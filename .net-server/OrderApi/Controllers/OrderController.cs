// Controllers/OrderController.cs
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/orders")]
public class OrderController : ControllerBase
{
    private readonly AppDbContext _dbContext;

    public OrderController(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpPost]
    public IActionResult PostOrder([FromBody] Order order)
    {
        if (order == null)
        {
            return BadRequest("Invalid order data");
        }

        _dbContext.Orders.Add(order);
        _dbContext.SaveChanges();

        return Ok();
    }
}
