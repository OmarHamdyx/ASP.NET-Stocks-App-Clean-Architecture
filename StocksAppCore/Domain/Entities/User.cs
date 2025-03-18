namespace Domain.Entities
{
    public class User
	{
		public Guid UserId { get; set; }
		public string? Name { get; set; }
		public string? UserName { get; set; }
		public string? Password { get; set; }
		public string? Email { get; set; }
		public ICollection<UserBuyOrder> UserBuyOrders { get; set; } = [];	
		public ICollection<UserSellOrder> UserSellOrders { get; set; } = [];	
	}
}
