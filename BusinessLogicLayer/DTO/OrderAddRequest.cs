
namespace eCommerce.OrdersMicroservice.BusinessLogicLayer.DTO;

public record OrderAddRequest(Guid UserID, DateTime OrderDate, List<OrderItemAddRequest> OrderItemAdds)
{
    public OrderAddRequest() : this(default, default, default)
    {

    }
}
