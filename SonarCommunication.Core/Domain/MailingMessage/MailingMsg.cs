using SonarCommunication.Core.Domain.VolontersManagment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonarCommunication.Core.Domain.MailingMessage
{
    public class MailingMsg
    {
        /// <summary>
        /// Список волонтеров
        /// </summary>
        public List<Volunteer> volunteers { get; set; }
        /// <summary>
        /// Сообщение
        /// </summary>
        public string Message { get; set; }
    }
}
