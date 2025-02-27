
namespace eCommerce.OrdersMicroservice.BusinessLogicLayer.DTO;

public record OrderUpdateRequest(Guid OrderID, Guid UserID, DateTime OrderDate, List<OrderItemAddRequest> OrderItemAdds)
{
    public OrderUpdateRequest() : this(default, default, default, default)
    {

    }
}
