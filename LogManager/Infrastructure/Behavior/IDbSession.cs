using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace LogManager.Infrastructure.Behavior
{
    public interface IDbSession
    {
        public IDbConnection Connection { get; }
        public IDbTransaction Transaction { get; set; }
        public IDatabaseConfiguration DatabaseConfiguration { get; set; }
    }
}
