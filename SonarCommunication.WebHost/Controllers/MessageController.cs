using Microsoft.AspNetCore.Mvc;
using SonarCommunication.Core.Abstraction.Repositories;
using SonarCommunication.Core.Domain.MailingMessage;
using SonarCommunication.Core.Domain.VolontersManagment;

namespace SonarCommunication.WebHost.Controllers
{
    /// <summary>
    /// Котроллер рассылки сообщений
    /// </summary>
    [ApiController]
    [Route("api/v1/[controller]")]
    public class MessageController: ControllerBase
    {
        private readonly ILogger<MessageController> logger;
        private readonly IMailingAll<Volunteer> _mailingAll;

        public MessageController (ILogger<MessageController> logger, IMailingAll<Volunteer> mailingAll)
        {
            this.logger = logger;
            _mailingAll = mailingAll;
        }

        /// <summary>
        /// Получаем список всех волонтеров, которым будем рассылать
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<List<Volunteer>>> GetAllVolunteers()
        {
            var volunteers = await _mailingAll.GetAllVolunters();
            return Ok(volunteers);
        }

        /// <summary>
        /// Рассылка пользователям уведомления о новым объявлений
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<List<MailingMsg>>> MailingMessageAll(string msg)
        {
            var usersForMailing = await _mailingAll.GetUserForMailing();

            if (usersForMailing is null)
            {
                return BadRequest("Нет пользователей для рассылки");
            }
            
            //отбираем пользователей, которым нужно рассылать в телеграмм сообщения
            var userTelegram = usersForMailing.Where(x=>x.CommunicationProperty.telegramCmn is true).ToList(); 
            logger.LogInformation($"Кол-во пользователей, которым можно разослать сообщения: {userTelegram.Count()}");

            // отбираем пользователей, которым нужно рассылать в whatsup
            var userWhatsUp = usersForMailing.Where(x=>x.CommunicationProperty.WhtasUpCmn is true).ToList();
            logger.LogInformation($"Кол-во пользователей, которые хотят получать рассылку через whatsup: {userWhatsUp.Count()}");
            
            //Пока просто коллекцию возвращаем, которая содержит список рассылаемых, потом надо сделать,
            // что бы была рассылка по принципу реле (RabbitMQ надо подключить)
            return Ok(usersForMailing);

        }
    }
}
