using System.ComponentModel.DataAnnotations;

namespace ClientApp.Models
{
    public class AdressModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "É necessário informa um endereço nesse campo")]
        public string PrincipalAdress { get; set; }

        public string? OtherAdress { get; set; }

        public int ClientId { get; set; }
        public virtual ClientModel? Client { get; set; }
    }
}
