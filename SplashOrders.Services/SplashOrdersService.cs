using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SplashOrders.Domain;
using SplashOrders.Domain.Models;

namespace SplashOrders.Services
{
    public class SplashOrdersService
    {
        private readonly ILogger<SplashOrdersService> _logger;
        private readonly IServiceProvider _serviceProvider;

        public SplashOrdersService(ILogger<SplashOrdersService> logger, IServiceProvider serviceProvider)
        {
            _logger = logger;
            _serviceProvider = serviceProvider;
        }

        public async Task<int> PlaceOrderAsync(Order order)
        {
            try
            {
                _logger.LogTrace("Fetching data context...");
                var dataContext = _serviceProvider.GetService<DataContext>();

                _logger.LogTrace("Adding order...");
                await dataContext.AddAsync(order);
                _logger.LogTrace("Saving...");
                await dataContext.SaveChangesAsync();

                return order.Id;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                throw;
            }
        }
    }
}