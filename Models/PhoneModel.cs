using System.ComponentModel.DataAnnotations;

namespace ClientApp.Models
{
    public class PhoneModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "É necessário informar o telefone comercial")]
        [Phone(ErrorMessage = "Informe um número válido")]
        public string ComercialPhone { get; set; }

        [Phone(ErrorMessage = "Informe um número válido")]
        public string? ResidencialPhone { get; set; }

        [Phone(ErrorMessage = "Informe um número válido")]
        public string? OtherPhone { get; set; }

        public int ClientId { get; set; }
        public virtual ClientModel? Client { get; set; }
    }
}
