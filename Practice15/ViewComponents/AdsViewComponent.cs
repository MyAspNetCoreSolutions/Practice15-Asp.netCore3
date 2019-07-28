using Microsoft.AspNetCore.Mvc;
using Practice15.Models;
using System.Collections.Generic;

namespace Practice15.ViewComponents
{
    public class AdsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            List<Ads> adsList = new List<Ads>();
            for (int i = 0; i < 4; i++)
            {
                adsList.Add(new Ads {
                    ImageName = "https://via.placeholder.com/180px100.png",
                    Description = "Description 6543 3sa sd31a =" + i,
                    Title = "Title-" + i
                });
            }
            return View(adsList);
        }
    }
}
