
using Cep.Entities;
using Refit;
using System.Threading.Tasks;

namespace Cep
{/*
  * Uma interface onde criamos uma task para fazer o request a API
  */
    interface ICepApiService
    {
        [Get("/ws/{cep}/json/")]
        Task<CepResponse> GetAddressAssync(string cep);
        
    }
}
