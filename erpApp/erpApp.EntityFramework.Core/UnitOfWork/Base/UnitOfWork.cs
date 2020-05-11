using erpApp.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace erpApp.EntityFramework.Core
{
  public abstract class UnitOfWork : IUnitOfWork
  {
    DbContext _context;

    public UnitOfWork(DbContext context)
    {
      _context = context;
    }

    public void Save()
    {
      _context.SaveChanges();
    }

    private bool disposed = false;

    protected virtual void Dispose(bool disposing)
    {
      if (!this.disposed)
      {
        if (disposing)
        {
          _context.Dispose();
        }
      }
      this.disposed = true;
    }

    public virtual void Dispose()
    {
      Dispose(true);
      GC.SuppressFinalize(this);
    }
  }
}
