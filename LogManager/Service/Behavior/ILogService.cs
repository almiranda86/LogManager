using LogManager.Domain;
using LogManager.Domain.Command;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LogManager.Service.Behavior
{
    public interface ILogService
    {
        Task<CreateLogResult> Create(CreateLogRequest createLogRequest);
        Task Update(Log log);
        Task Delete(int logId);

        Task<Log> Get(int logId);

        Task<List<Log>> GetAll(int logId);

        Task<List<Log>> GetFilteredBy(int logId, string ipAddress, string userId, DateTime executionDate);
    }
}
