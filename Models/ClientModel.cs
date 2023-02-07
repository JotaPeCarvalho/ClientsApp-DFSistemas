using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace ClientApp.Models
{
    public class ClientModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o nome do cliente")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Digite a data de nascimento do cliente")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Digite o RG do cliente")]
        [MinLength(6, ErrorMessage = "O RG deve ter no mínimo 6 digitos")]
        public string Rg { get; set; }

        [Required(ErrorMessage = "Digite o CPF do cliente")]
        [MinLength(11, ErrorMessage = "O CPF deve possui 11 números")]
        public string Cpf { get; set; }

        public virtual SocialMidiaModel? SocialMidia { get; set; }

        public virtual PhoneModel? Phone { get; set; }

        public virtual AdressModel? Adress { get; set; }
    }
}
