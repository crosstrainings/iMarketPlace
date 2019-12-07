using iMarketPlace.Web.Models;
using MarketPlace.Entities.Advertisements;
using System.Linq;
using System.Web.Mvc;

namespace iMarketPlace.Web.Controllers
{
    /// <summary>
    /// SOME SUMMARY HERE
    /// </summary>
    /// <seealso cref="iMarketPlace.Web.Controllers.BaseController" />
    public class ProductController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductController"/> class.
        /// </summary>
        public ProductController()
        {
        }

        /// <summary>
        /// Creates the specified advertisement.
        /// </summary>
        /// <param name="advertisement">The advertisement To Add An Object.</param>
        /// <returns></returns>
        public ActionResult Create(Advertisement advertisement)
        {
            var user = GetSession<UserSessionInfo>(USER_SESSION);
            advertisement.SellerId = user.Id;
            bool isAdded = _advertisementService.Add(advertisement);
            return RedirectToAction("Profile", "User");
        }

        /// <summary>
        /// Loads the specified skip.
        /// </summary>
        /// <param name="skip">The skip.</param>
        /// <param name="take">The take.</param>
        /// <returns></returns>
        public ActionResult Load(int skip = 0, int take = 10)
        {
            var advertisements = _advertisementService.Get().Skip(skip).Take(take).ToList();
            var view = ConvertViewToString("_AdvertisementListView", advertisements);
            return Json(new { view, advertisements.Count }, JsonRequestBehavior.AllowGet);
        }
    }
}