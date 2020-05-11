namespace erpApp.EntityFramework.Core
{
  public class ClienteFornecedorUnitOfWork : UnitOfWork
  {
    private ClienteFornecedorContext _context;

    public ClienteFornecedorUnitOfWork(ClienteFornecedorContext context) : base(context)
    {
      _context = context;
    }

    public ClienteFornecedorRepository CliForRepository
    {
      get
      {
        if (_cliForRepository == null)
          _cliForRepository = new ClienteFornecedorRepository(_context);

        return _cliForRepository;
      }

    }
    private ClienteFornecedorRepository _cliForRepository = null;
  }
}
