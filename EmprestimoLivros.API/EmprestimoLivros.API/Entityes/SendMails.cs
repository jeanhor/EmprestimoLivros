using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmprestimoLivros.API.Entityes
{
    public class SendMails
    {

        public string [] Emails { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public bool isHtml { get; set; }
    }
}
