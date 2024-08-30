using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JSONParser.Controllers
{
    public class JSONParserController : Controller
    {
        // POST: JSONParserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ParseJSON([FromBody] string json)
        {
            //var tokens
            return Json(json);
        }
    }
}
