using System;
using System.Collections.Generic;
using System.Text;

namespace LogManager.Domain
{
    public class Log
    {
        public string IpAddress { get; set; }
        public string UserIdentifier { get; set; }
        public string UserId { get; set; }
        public DateTime ExecutionDate { get; set; }
        public string ClientRequest { get; set; }
        public int StatusResponse { get; set; }
        public uint BytesReturned { get; set; }
        public string ResponseObject { get; set; }
        public string General { get; set; }
    }
}