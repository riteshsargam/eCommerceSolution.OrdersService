using eCommerce.OrdersMicroservice.DataAccessLayer.Entities;
using MongoDB.Driver;

namespace eCommerce.OrdersMicroservice.DataAccessLayer.RepositoryContracts;

public interface IOrdersRepository
{
    /// <summary>
    /// Retrieves all Orders asynchronously
    /// </summary>
    /// <returns>Returns all orders from the orders collection</returns>
    Task<IEnumerable<Order>> GetOrders();

    /// <summary>
    /// Retrieves all orders based on the specified condition asynchronously
    /// </summary>
    /// <param name="filter">The condition to filter Orders</param>
    /// <returns>Returning a collection of matching orders</returns>
    Task<IEnumerable<Order?>> GetOrdersByCondition(FilterDefinition<Order> filter);

    /// <summary>
    /// Retrieves a single orders based on the specified condition asynchronously
    /// </summary>
    /// <param name="filter">The condition to filter Orders</param>
    /// <returns>Returning matching orders</returns>
    Task<Order?> GetOrderByCondition(FilterDefinition<Order> filter);

    /// <summary>
    /// Adds a new Order into the Orders collection asynchronously
    /// </summary>
    /// <param name="order">The order to be added</param>
    /// <returns>Returns the added Orders object or null if uncuccessfull</returns>
    Task<Order?> AddOrder(Order order);

    /// <summary>
    /// Updates an existing order asynchronously
    /// </summary>
    /// <param name="order">The order to be added</param>
    /// <returns>Returns the updated Orders object or null if uncuccessfull</returns>
    Task<Order?> UpdateOrder(Order order);

    /// <summary>
    /// Deletes the order asynchronously
    /// </summary>
    /// <param name="orderID">The OrderID based on which we need to delete the order</param>
    /// <returns>Return true if the deletion is successful, false otherwise</returns>
    Task<bool> DeleteOrder(Guid orderID);
}
