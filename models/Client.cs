
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Product_manager.models;
[Table("clients")]
public class Client
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }

    [Column("full_name")]
    [MaxLength(250)]
    public string FullName { get; set; }

    [Column("direction")]
    [MaxLength(300)]
    public string Direction { get; set; }

    [Column("phone_number")]
    [MaxLength(20)]
    public string PhoneNumber { get; set; }


    public Client(string fullName, string direction, string phoneNumber)
    {
        FullName = fullName.ToLower().Trim(); ;
        Direction = direction.ToLower().Trim(); ;
        PhoneNumber = phoneNumber;
    }

    public Client()
    {

    }
}
