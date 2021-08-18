using LogManager.Domain;
using LogManager.Repository.Behavior;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LogManager.Repository.Lookup
{
    public class LogLookup : ILogLookup
    {
        public Task<Log> Get(int logId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Log>> GetAll(int logId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Log>> GetFilteredBy(int logId, string ipAddress, string userId, DateTime executionDate)
        {
            throw new NotImplementedException();
        }
    }
}
