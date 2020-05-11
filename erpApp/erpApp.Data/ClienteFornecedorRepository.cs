using erpApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace erpApp.Data
{
  public class ClienteFornecedorRepository : IRepository<ClienteFornecedorCxt>
  {
    public ClienteFornecedorRepository(DbContext context)
    {

    }


    public void Delete(int CodColigada, string codigo)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<ClienteFornecedorCxt> GetAll()
    {
      throw new NotImplementedException();
    }

    public ClienteFornecedorCxt GetByID(int CodColigada, string codigo)
    {
      throw new NotImplementedException();
    }

    public ClienteFornecedorCxt GetByID(string codigo)
    {
      throw new NotImplementedException();
    }

    public ClienteFornecedorCxt GetByID(int codigo)
    {
      throw new NotImplementedException();
    }

    public void Insert(ClienteFornecedorCxt entity)
    {
      throw new NotImplementedException();
    }

    public void Save()
    {
      throw new NotImplementedException();
    }

    public void Update(ClienteFornecedorCxt entity)
    {
      throw new NotImplementedException();
    }
  }
}
