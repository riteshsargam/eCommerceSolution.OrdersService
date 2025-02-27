
namespace eCommerce.OrdersMicroservice.BusinessLogicLayer.DTO;

public record OrderResponse(Guid OrderID, Guid UserID, DateTime OrderDate, decimal TotalBill, List<OrderItemResponse> OrderItemAdds)
{
    public OrderResponse() : this(default, default, default, default, default)
    {

    }
}
