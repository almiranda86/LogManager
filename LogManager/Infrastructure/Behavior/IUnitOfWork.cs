using System;
using System.Collections.Generic;
using System.Text;

namespace LogManager.Infrastructure.Behavior
{
    public interface IUnitOfWork : IDisposable
    {
        void BeginTransaction();
        void Commit();
        void Rollback();
    }
}
