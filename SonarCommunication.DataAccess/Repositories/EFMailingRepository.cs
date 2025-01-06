using Microsoft.EntityFrameworkCore;
using SonarCommunication.Core.Abstraction.Repositories;
using SonarCommunication.Core.Domain;
using SonarCommunication.Core.Domain.VolontersManagment;
using SonarCommunication.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonarCommunication.DataAccess.Repositories
{
    public class EFMailingRepository<T> : IMailingAll<T> where T : BaseEntity
    {
        private DataContext _ctx;

        public EFMailingRepository(DataContext ctx)
        {
            _ctx = ctx;
        }

        public Task AlarmAboutException(string errMsg)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Volunteer>> GetAllVolunters()
        {
            return await _ctx.Volunteers.ToListAsync();
        }

        public async Task<List<Volunteer>> GetUserForMailing()
        {
            return await _ctx.Volunteers.Where(x=>x.CommunicationProperty != null).ToListAsync();
        }
    }
}
