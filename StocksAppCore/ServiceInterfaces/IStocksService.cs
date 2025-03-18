using Application.DtoModels;

namespace Application.Interfaces
{
    public interface IStocksService
	{
		public Task<BuyOrderResponse?> CreateBuyOrderAsync(BuyOrderRequest? buyOrderRequest);
		public Task<SellOrderResponse?> CreateSellOrderAsync(SellOrderRequest? sellOrderRequest);
		public Task<List<BuyOrderResponse?>> GetBuyOrdersAsync();
		public Task<List<SellOrderResponse?>> GetSellOrdersAsync();
			
	}
}
