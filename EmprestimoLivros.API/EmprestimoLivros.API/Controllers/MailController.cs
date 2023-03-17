using EmprestimoLivros.API.Entityes;
using EmprestimoLivros.API.Infra.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmprestimoLivros.API.Controllers
{
    [Route("api/mails")]
    [ApiController]
    public class MailController : Controller
    {
        private readonly IMailService _mailService;
        public MailController(IMailService mailService)
        {
            _mailService = mailService;
        }
        [HttpPost]
        public IActionResult SendMail([FromBody]SendMails sendMails)
        {
            _mailService.SendMail(sendMails.Emails, sendMails.Subject, sendMails.Body, sendMails.isHtml);
            return Ok();
        }
    }
}
