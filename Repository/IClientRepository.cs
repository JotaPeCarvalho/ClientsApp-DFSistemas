using ClientApp.Models;

namespace ClientApp.Repository
{
    public interface IClientRepository
    {
        Task<List<ClientModel>> SearchAllClients();
        Task<ClientModel> SearchClientById(int id);
        Task<ClientModel> AddClient(ClientModel client);
        Task<ClientModel> UpdateClient(ClientModel client);
        Task<bool> Delete(int id);
        
    }
}
