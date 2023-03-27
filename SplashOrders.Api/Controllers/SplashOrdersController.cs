using Microsoft.AspNetCore.Mvc;
using SplashOrders.Domain.Models;
using SplashOrders.Services;

namespace SplashOrders.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SplashOrdersController : ControllerBase
    {
        private readonly ILogger<SplashOrdersController> _logger;
        private readonly SplashOrdersService _splashOrdersService;

        public SplashOrdersController(ILogger<SplashOrdersController> logger, SplashOrdersService splashOrdersService)
        {
            _logger = logger;
            _splashOrdersService = splashOrdersService;
        }

        [HttpPost]
        [Route("PlaceOrder")]
        public async Task<int> PlaceOrderAsync(Order order)
        {
            try
            {
                _logger.LogTrace("Placing order...");
                return await _splashOrdersService.PlaceOrderAsync(order);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                throw;
            }
        }
    }
}
