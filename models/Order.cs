using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Product_manager.models;

[Table("orders")]
public class Order
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }

    [Column("order_day")]
    public DateOnly OrderDay { get; set; }

    [Column("client_id")]
    public int ClientId { get; set; }

    [Column("client_name")]
    public string ClientName { get; set; }

    [Column("client_direction")]
    public string ClientDirection { get; set; }

    [Column("client_phone")]
    public string ClientPhone { get; set; }

    public virtual ICollection<OrderProduct> OrderProducts { get; set; } = new List<OrderProduct>();

    public Order(DateOnly orderDay, int clientId, string clientName, string clientDirection, string clientPhone)
    {
        OrderDay = orderDay;
        ClientId = clientId;
        ClientName = clientName.ToLower().Trim();
        ClientDirection = clientDirection.ToLower().Trim();
        ClientPhone = clientPhone;
    }
    public Order() { }
}
