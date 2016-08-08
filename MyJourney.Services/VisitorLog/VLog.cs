using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyJourney.Models;
using MyJourney.AppRepository;

namespace MyJourney.Services.VisitorLog
{
    public class VLog : IVLog
    {
        IRepository<Models.VisitorLog> vlog;

        public VLog(IRepository<Models.VisitorLog> _vlog)
        {
            vlog = _vlog;
        }

        public void Save(string Url)
        {
            Models.VisitorLog log = new Models.VisitorLog();

            log.Id = Guid.NewGuid();
            log.Url = Url;
            log.Created = DateTime.UtcNow;

            vlog.Insert(log);
        }
    }
}
