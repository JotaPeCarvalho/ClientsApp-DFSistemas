using ClientApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClientApp.Data.Map
{
    public class ClientMap: IEntityTypeConfiguration<ClientModel>
    {
        public void Configure(EntityTypeBuilder<ClientModel> builder)
        {

            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.SocialMidia)
                   .WithOne(x => x.Client)
                   .HasForeignKey<SocialMidiaModel>(x => x.ClientId);
            
            builder.HasOne(x => x.Phone)
                   .WithOne(x => x.Client)
                   .HasForeignKey<PhoneModel>(x => x.ClientId);
           
            builder.HasOne(x => x.Adress)
                   .WithOne(x => x.Client)
                   .HasForeignKey<AdressModel>(x => x.ClientId);
        }
    
    }
}
