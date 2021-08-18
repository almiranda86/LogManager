using LogManager.Domain.Command;
using LogManager.Service.Behavior;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LogManager.Handler
{
    public class CreateLogRequestHandler : IRequestHandler<CreateLogRequest, CreateLogResult>
    {
        private readonly ILogService _logService;

        public CreateLogRequestHandler(ILogService logService)
        {
            _logService = logService;
        }

        public Task<CreateLogResult> Handle(CreateLogRequest request, CancellationToken cancellationToken)
        {
            _logService.Create(request);

            throw new NotImplementedException();
        }
    }
}
