using System;
using System.Collections.Generic;
using System.Text;

namespace erpApp.Model
{
  public interface IUnitOfWork : IDisposable
  {
    void Save();
  }
}
