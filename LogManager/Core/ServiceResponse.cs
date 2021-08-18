using System;
using System.Collections.Generic;
using System.Text;

namespace LogManager.Core
{
    public class ServiceResponse
    {
        public DateTime IssuedOn { get; set; } = DateTime.Now;
        public string Status { get; set; }
        public string StatusDescription { get; set; }

        public void SetOk() => Status = "Ok";
    }
}
