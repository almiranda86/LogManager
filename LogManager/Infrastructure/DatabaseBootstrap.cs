using Dapper;
using LogManager.Infrastructure.Behavior;
using System.Data.SQLite;
using System.Linq;

namespace LogManager.Infrastructure
{
    public class DatabaseBootstrap : IDatabaseBootstrap
    {
        private readonly IDbSession _dbSession;
        private readonly IUnitOfWork _unitOfWork;

        public DatabaseBootstrap(IDbSession dbSession, IUnitOfWork unitOfWork)
        {
            _dbSession = dbSession;
            _unitOfWork = unitOfWork;
        }

        public void Setup()
        {
            _unitOfWork.BeginTransaction();

            var table = _dbSession.Connection.Query<string>(@"SELECT name 
                                                     FROM sqlite_master 
                                                    WHERE type='table' 
                                                      AND name = 'Log';");
            var tableName = table.FirstOrDefault();
            if (!string.IsNullOrEmpty(tableName) && tableName == "Log")
                return;

            _dbSession.Connection.Execute(@"Create Table logmanager ( );");

            _unitOfWork.Commit();
        }
    }
}
