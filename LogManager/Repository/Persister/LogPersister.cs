using Dapper;
using LogManager.Domain;
using LogManager.Domain.Command;
using LogManager.Infrastructure.Behavior;
using LogManager.Repository.Behavior;
using LogManager.Repository.SQL;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LogManager.Repository.Persister
{
    public class LogPersister : ILogPersister
    {
        private readonly IDbSession _dbSession;
        private readonly IUnitOfWork _unitOfWork;

        public LogPersister(IDbSession dbSession, IUnitOfWork unitOfWork)
        {
            _dbSession = dbSession;
            _unitOfWork = unitOfWork;
        }

        public async Task<CreateLogResult> Create(CreateLogRequest createLogRequest)
        {
            _unitOfWork.BeginTransaction();
            
            var response = await _dbSession.Connection.ExecuteAsync(SQLQueries.CreateLog(), createLogRequest);
            
            _unitOfWork.Commit();

            CreateLogResult createLogResult = new CreateLogResult()
            {

            };

            return createLogResult;
        }

        public Task<CreateLogResult> CreateBatch(List<CreateLogRequest> collCreateLogRequest)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int logId)
        {
            throw new NotImplementedException();
        }

        public Task Update(Log log)
        {
            throw new NotImplementedException();
        }
    }
}
