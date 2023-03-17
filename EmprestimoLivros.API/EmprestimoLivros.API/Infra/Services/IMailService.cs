using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmprestimoLivros.API.Infra.Services
{
    public interface IMailService
    {
        void SendMail(string[] emails, string subject, string body, bool isHtml = false);
    }
}
