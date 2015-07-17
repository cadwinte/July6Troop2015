//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;

//namespace Layouts.Controllers
//{
//    public class GetQuoteController : Controller
//    {
//        // GET: GetQuote
//        [ChildActionOnly]
//        public ActionResult GetQuote()
//        {
//            var quoteText = "this is bat country";

//            List<string> quotes = new List<string>();
//            quotes.Add("What we have here, is a failure, to communicate");
//            quotes.Add("Kazakhstan Number 1 exporter of Potassium");
//            quotes.Add("You either die a hero, or live long enough to see yourself become the villain");
//            quotes.Add("I award you no points, and may God have mercy on your soul");
//            quotes.Add("Like anyone could even know that, Napoleon");

//            Random x = new Random();
//            int y = x.Next(5);

//            if (y == 1)
//                quoteText = "What we have here, is a failure, to communicate";

//            else if (y == 2)
//                quoteText = "Kazakhstan Number 1 exporter of Potassium";

//            else if (y == 3)
//                quoteText = "You either die a hero, or live long enough to see yourself become the villain";

//            else if (y == 4)
//                quoteText = "I award you no points, and may God have mercy on your soul";

//            else
//                quoteText = "Like anyone could even know that, Napoleon";

//            return PartialView("_GetQuote", quoteText);
//        }
//    }
//}