using AutoMapper;
using ClientApp.Data;
using ClientApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ClientApp.Repository
{
    public class ClientRepository : IClientRepository
    {

        private readonly DataBaseContext _dataContext;
        public ClientRepository(DataBaseContext bancoContext)
        {
            _dataContext = bancoContext;
        }

        //Adiciona um cliente no banco e retorna ele mesmo
        public async Task<ClientModel> AddClient(ClientModel client)
        {
            await _dataContext.Clients.AddAsync(client);
            await _dataContext.SaveChangesAsync();

            return client;
        }

        //Retorna todos os clientes no banco
        public async Task<List<ClientModel>> SearchAllClients()
        {
            return await _dataContext.Clients
                                      .AsNoTracking()
                                      .Include(x => x.SocialMidia)
                                      .Include(x => x.Phone)
                                      .Include(x => x.Adress)
                                      .ToListAsync();
        }

        //Retorna o cliente com o ID especificado
        public async Task<ClientModel> SearchClientById(int id)
        {
             return await _dataContext.Clients
                               .AsNoTracking()
                               .Include(x => x.SocialMidia)
                               .Include(x => x.Phone)
                               .Include(x => x.Adress)
                               .FirstOrDefaultAsync(x => x.Id == id);
            
        }

        //Atuaiza um cliente
        public async Task<ClientModel> UpdateClient(ClientModel client)
        {
            var clientById = await SearchClientById(client.Id);

           if(client == null)
                throw new System.Exception("Houve um erro na atualização do cliente");



            clientById.Name = client.Name;          
            clientById.Cpf = client.Cpf;
            clientById.Rg  = client.Rg;

            clientById.Phone.ComercialPhone = client.Phone.ComercialPhone;
            clientById.Phone.ResidencialPhone = client.Phone.ResidencialPhone;
            clientById.Phone.OtherPhone = client.Phone.OtherPhone;

            clientById.Adress.OtherAdress = client.Adress.OtherAdress;
            clientById.Adress.PrincipalAdress = client.Adress.PrincipalAdress;

            clientById.SocialMidia.LinkedinUrl = client.SocialMidia.LinkedinUrl;
            clientById.SocialMidia.FacebookUrl = client.SocialMidia.FacebookUrl;
            clientById.SocialMidia.InstagramUrl = client.SocialMidia.InstagramUrl;
            clientById.SocialMidia.TwitterUrl = client.SocialMidia.TwitterUrl;
            clientById.Date = client.Date;

            _dataContext.Clients.Update(clientById);
            await _dataContext.SaveChangesAsync();

            return clientById;
        }

        //Deleta o Cliente
        public async Task<bool> Delete(int id)
        {
            ClientModel clienteById = await SearchClientById(id);
            if (clienteById == null)
                throw new System.Exception("Houve um erro na deleção do cliente");
            
           _dataContext.Clients.Remove(clienteById);
            await _dataContext.SaveChangesAsync();
            return true;
        }

    }
}
