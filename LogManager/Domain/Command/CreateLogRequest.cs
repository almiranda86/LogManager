using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogManager.Domain.Command
{
    public class CreateLogRequest : IRequest<CreateLogResult>
    {
    }
}
