using EmprestimoLivros.API.Entityes;
using EmprestimoLivros.API.Infra.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
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
        private readonly IConfiguration _config;

        public MailController(IMailService mailService,IConfiguration config)
        {
            _mailService = mailService;
            _config = config;
        }

        [HttpPost]
        public IActionResult SendMail([FromBody] SendMails sendMails)
        {
            _mailService.SendMail(sendMails.Emails, sendMails.Subject, sendMails.Body, sendMails.isHtml);
            return Ok();

        }
       
       
    }
}
