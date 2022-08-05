using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Clients
{
    public class ClientCore
    {
        readonly IClientsRepository  _clientRepository;

        public ClientCore(IClientsRepository clientsRepository)
        {
            _clientRepository = clientsRepository;
        }

        public async Task<int> AddAsync(string firstName, string lastName, string phoneNumber, string nip, string address)
        {
            Client client = new Client()
            {
                FirstName = firstName,
                LastName = lastName,
                PhoneNumber = phoneNumber,
                Address = address,
                NIP = nip

            };

            return await _clientRepository.AddAsync(client);
        }

        public async Task UpdateAsync(int id, string firstName, string lastName, string phoneNumber, string nip,
            string address)
        {
            Client client = new Client()
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                PhoneNumber = phoneNumber,
                Address = address,
                NIP = nip

            };

            await _clientRepository.UpdateAsync(client);
        }

        public async Task<List<Client>> GetAllAsync()
        {
            return await _clientRepository.GetAllAsync();
        }

        public async Task<Client> GetClientByIdAsync(int id)
        {
            return await _clientRepository.GetByIdAsync(id);
        }

        public async Task<List<Client>> GetClientsByName(string name)
        {
            return await _clientRepository.GetByNameAsync(name);
        }

        public async Task DeleteAsync(int id)
        {
            await _clientRepository.DeleteAsymc(id);
        }

    }
}
