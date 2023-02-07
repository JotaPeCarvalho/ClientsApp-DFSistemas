using ClientApp.Models;
using ClientApp.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ClientApp.Controllers
{
    public class ClientController : Controller
    {
        private readonly IClientRepository _clientRepository;
        public ClientController(IClientRepository clienteRepository)
        {
           _clientRepository= clienteRepository;
        }

        //Listagem de Clientes
        public async Task<IActionResult> Index()
        {
           List<ClientModel> clients = await _clientRepository.SearchAllClients();
            return View(clients);
        }

        //View para cliar um cliente
        public async Task<IActionResult> Create()
        {
            return View();
        }


        //Método para criar um Cliente
        [HttpPost]
        public async Task<IActionResult> Create(ClientModel client)
        {
            try
            {
                if(ModelState.IsValid) 
                { 
                    await _clientRepository.AddClient(client);
                    TempData["MensagemSucesso"] = "Cliente cadastrado com sucesso";
                    return RedirectToAction("Index");
                }

                return View(client);
                
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos cadastrar seu cliente, " +
                    $"tente novamente! Detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }

        //View para editar um cliente
        public async Task<IActionResult> Edit(int id)
        {
            ClientModel client = await _clientRepository.SearchClientById(id);
            return View(client);
        }

        //Método para atualizar um cliente
        [HttpPost]
        public async Task<IActionResult> Update(ClientModel client)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _clientRepository.UpdateClient(client);
                    TempData["MensagemSucesso"] = "O cliente foi atualizado com sucesso!";
                    return RedirectToAction("Index");
                }
                return View("Edit", client);
            }
            catch (Exception erro)
            {

                TempData["MensagemErro"] = $"Não foi possível atualizar o cliente! Descrição do erro: {erro.Message}";
                return RedirectToAction("Edit", client);
            }
        }

        //View para ver mais informações sobre o cliente
        public async Task<IActionResult> ViewMore(int id)
        {
            ClientModel client = await _clientRepository.SearchClientById(id);
            return View(client);
        }

        //View para confirmar exclusão do cliente
        public async Task<IActionResult> DeleteConfirmation(int id)
        {
            ClientModel client = await _clientRepository.SearchClientById(id);
            return View(client);
        }

        //Método para apagar um cliente
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _clientRepository.Delete(id);
                TempData["MensagemSucesso"] = "Esse cliente foi apagado com sucesso!";
                return RedirectToAction("index");
            }
            catch(Exception erro)
            {
                TempData["MensagemErro"] = $"Não foi possível apagar esse cliente! Detalhes do erro: {erro.Message}";
                return RedirectToAction("DeleteConfirmation");
            }
        }


    }
}
