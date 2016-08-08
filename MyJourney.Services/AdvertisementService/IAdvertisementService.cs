using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyJourney.Models;

namespace MyJourney.Services.AdvertisementService
{
    public interface IAdvertisementService
    {
        IEnumerable<Advertisement> GetTop10Adveetisements();
        Advertisement GetAdvertisementDetailByName(string title);
    }
}
