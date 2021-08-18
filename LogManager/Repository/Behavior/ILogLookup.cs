using LogManager.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LogManager.Repository.Behavior
{
    public interface ILogLookup
    {
        Task<Log> Get(int logId);

        Task<List<Log>> GetAll(int logId);

        Task<List<Log>> GetFilteredBy(int logId, string ipAddress, string userId, DateTime executionDate);
    }
}
