using System.ComponentModel.DataAnnotations;

namespace ClientApp.Models
{
    public class SocialMidiaModel
    {
        [Key]
        public int Id { get; set; }

        public string? TwitterUrl { get; set; }
        public string? InstagramUrl { get; set; }
        public string? LinkedinUrl { get; set; }
        public string? FacebookUrl { get; set; }
        public int ClientId { get; set; }
        public virtual ClientModel? Client { get; set; }

    }
}
