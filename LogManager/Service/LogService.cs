using LogManager.Domain;
using LogManager.Domain.Command;
using LogManager.Repository.Behavior;
using LogManager.Service.Behavior;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LogManager.Service
{
    public class LogService : ILogService
    {
        private readonly ILogLookup _logLookup;
        private readonly ILogPersister _logPersister;
        public LogService(ILogLookup logLookup, ILogPersister logPersister)
        {
            _logLookup = logLookup;
            _logPersister = logPersister;
        }

        public async Task<CreateLogResult> Create(CreateLogRequest createLogRequest)
        {
            return await _logPersister.Create(createLogRequest);
        }

        public Task Delete(int logId)
        {
            throw new NotImplementedException();
        }

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

        public Task Update(Log log)
        {
            throw new NotImplementedException();
        }
    }
}
