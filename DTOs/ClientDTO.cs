

using System.ComponentModel.DataAnnotations;

namespace Product_manager.DTOs
{
    public class ClientDTO
    {
        [MaxLength(250, ErrorMessage = "Your full name can not have more than 250 characters")]
        public string FullName { get; set; }

        [MaxLength(300, ErrorMessage = "Your direction can not have mor than 300 characters")]
        public string Direction { get; set; }


        [MaxLength(20, ErrorMessage = "Ypur phone number can not have more than 20 characters")]
        public string PhoneNumber { get; set; }

    }
}