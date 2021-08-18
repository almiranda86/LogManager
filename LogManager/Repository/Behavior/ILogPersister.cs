using LogManager.Domain;
using LogManager.Domain.Command;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LogManager.Repository.Behavior
{
    public interface ILogPersister
    {
        Task<CreateLogResult> Create(CreateLogRequest createLogRequest);
        Task Update(Log log);
        Task Delete(int logId);
        Task<CreateLogResult> CreateBatch(List<CreateLogRequest> collCreateLogRequest);
    }
}
