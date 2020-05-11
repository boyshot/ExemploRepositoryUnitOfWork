using erpApp.Model;

namespace erpApp.EntityFramework.Core
{
  public class ClienteFornecedorRepository : RepositoryBase<ClienteFornecedorCxt> 
  {
    public ClienteFornecedorRepository(ClienteFornecedorContext context) : base(context) { }
  }
}
