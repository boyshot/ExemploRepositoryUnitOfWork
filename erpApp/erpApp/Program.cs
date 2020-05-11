using erpApp.EntityFramework.Core;
using System;
using System.Linq;

namespace erpApp
{
  class Program
  {
    static void Main(string[] args)
    {
      using (var uow = new ClienteFornecedorUnitOfWork(new ClienteFornecedorContext()))
      {
        var clientes = uow.CliForRepository.Get(null,null).Take(10000).OrderBy(x => x.CodColigada);

        foreach (var cli in clientes)
        {
          Console.WriteLine($"Coligada:{cli.CodColigada}; Codigo: {cli.CodCfo}; Nome: {cli.NomeFantasia} ");
        }
      }

      Console.ReadKey();
    }
  }
}
