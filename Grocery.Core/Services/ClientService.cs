using Grocery.Core.Helpers;
using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Interfaces.Services;
using Grocery.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery.Core.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;
        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }
        
        public Client? Get(string email)
        {
            return _clientRepository.Get(email);
        }

        public Client? Get(int id)
        {
            return _clientRepository.Get(id);
        }

        public void AddClient(string name, string email, string password)
        {
            List<Client> clients = _clientRepository.GetAll();
            int newId = 0;
            foreach (Client client in clients)
            {
                if (client.Id > newId)
                {
                    newId = client.Id;
                }
            }
            string hashPassword = PasswordHelper.HashPassword(password);
            Client newClient = new Client(newId, name, email, hashPassword);
            _clientRepository.AddClient(newClient);
        }

        public List<Client> GetAll()
        {
            List<Client> clients = _clientRepository.GetAll();
            return clients;
        }
    }
}
