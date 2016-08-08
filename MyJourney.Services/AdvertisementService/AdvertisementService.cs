using System.Collections.Generic;
using System.Linq;
using MyJourney.Models;
using MyJourney.AppRepository;

namespace MyJourney.Services.AdvertisementService
{
    public class AdvertisementService : IAdvertisementService
    {
        IRepository<Advertisement> advertisements;

        public AdvertisementService(IRepository<Advertisement> _advertisements)
        {
            advertisements = _advertisements;
        }

        public IEnumerable<Advertisement> GetTop10Adveetisements()
        {
            IEnumerable<Advertisement> advs = advertisements.Get().Take(10);
            return advs;
        }

        public Advertisement GetAdvertisementDetailByName(string title)
        {
            return advertisements.Get().Where(p => p.Title == title.Trim()).Take(1).SingleOrDefault();
        }
    }
}
