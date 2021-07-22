using Refit;
using System;
using System.Threading.Tasks;

namespace Cep
{
    class Program
    {/*
      * Uma classe Task assincrona para esperar a informação da API
      */
        static async Task Main(string[] args)
        {
            /*
             * Solicitando ao usuario o Cep
             * e chamando o metodo task para iniciar o chamado a API
             */
            try
            {
                var cepClient = RestService.For<ICepApiService>("http://viacep.com.br");
                Console.Write("Informe seu CEP: ");
                string cepInformado = Console.ReadLine();
                Console.WriteLine("Consultando informações do CEP: " + cepInformado);

                var address = await cepClient.GetAddressAssync(cepInformado);

                Console.WriteLine("Logradouro: " + address.Logradouro);
            }
            catch(Exception e)
            {
                Console.WriteLine("Erro na consulta de cep: " + e.Message);
            }
        }
    }
}
