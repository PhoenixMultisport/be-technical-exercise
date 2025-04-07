[HttpGet("users/{id}/orders")]
public async Task<IActionResult> GetUserOrders(int id)
{
    using (var dbContext = new AppDbContext())
    {
        var orders = await dbContext.Orders
            .Where(o => o.UserId == id)
            .Select(o => new
            {
                o.Id,
                o.OrderDate,
                o.TotalAmount,
                o.Status,
                OrderItems = dbContext.OrderItems
                    .Where(oi => oi.OrderId == o.Id)
                    .Select(oi => new
                    {
                        oi.ProductName,
                        oi.Quantity,
                        oi.Price
                    })
                    .ToList()
            })
            .ToListAsync();

        return Ok(orders);
    }
}
