using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Clients
{
    public interface IClientsRepository
    {
        Task<int> AddAsync(Client client);

        Task <int>UpdateAsync(Client client);

        Task<List<Client>> GetAllAsync();

        Task<List<Client>> GetByNameAsync (string name);

        Task<Client> GetByIdAsync(int id);

        Task DeleteAsymc(int id);
    }
}
