using SonarCommunication.Core.Domain;
using SonarCommunication.Core.Domain.VolontersManagment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonarCommunication.Core.Abstraction.Repositories
{
    public interface IMailingAll<T> where T : BaseEntity
    {
        /// <summary>
        /// получить список пользователей, которым можно рассылать
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        Task <List<Volunteer>> GetUserForMailing();

        /// <summary>
        /// Сообщение об ошибке работы инфрастуркуты, при попытке массовой рассылки
        /// </summary>
        /// <param name="errMsg"></param>
        /// <returns></returns>
        Task AlarmAboutException(string errMsg);

        /// <summary>
        /// Получить список всех волонтеров
        /// </summary>
        /// <returns></returns>
        Task<List<Volunteer>> GetAllVolunters();

        
    }
}
