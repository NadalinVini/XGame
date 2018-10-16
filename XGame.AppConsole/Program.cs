using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XGame.Domain.Arguments.Jogador;
using XGame.Domain.Services;

namespace XGame.AppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando...");

            var service = new ServiceJogador();
            Console.WriteLine("Criei instancia do objeto");

            AutenticarJogadorRequest request = new AutenticarJogadorRequest();
            Console.WriteLine("Criei instancia do meu objeto request");

            var response = service.AutenticarJogador(request);

            //if (service.IsValid())
            //{
            //    return response;
            //}

           

            Console.ReadKey();
        }
    }
}
