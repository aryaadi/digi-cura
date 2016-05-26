using Avam.DigiCura.NgOne.UI.ActionsResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Avam.DigiCura.NgOne.UI.Controllers
{
    public abstract class DigiCuraControllerBase : Controller
    {
        public AdaptedJsonResult<T> AdaptedJson<T>(T model)
        {
            return new AdaptedJsonResult<T> {
                Data=model
            };
        }
    }
}