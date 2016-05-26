using Avam.DigiCura.NgOne.UI.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Avam.DigiCura.NgOne.UI.ActionsResults
{
    public class AdaptedJsonResult : JsonResult
    {
        #region ctors
        public AdaptedJsonResult()
        {
            ErrorMessages = new List<string>();
        }
        #endregion

        #region Public Properties
        public IList<string> ErrorMessages { get; private set; }
        #endregion

        #region Public Methods
        public void AddError(string errorMessage)
        {
            ErrorMessages.Add(errorMessage);
        }

        #endregion

        #region Overrides
        public override void ExecuteResult(ControllerContext context)
        {
            DoUninterestingBaseClassStuff(context);
            SerializeData(context.HttpContext.Response);
        }
        #endregion

        #region Helper Methods
        private void DoUninterestingBaseClassStuff(ControllerContext context)
        {
            Check.ThrowIfTrue(context == null, new ArgumentNullException("context"));
            Check.ThrowIfTrue(
                JsonRequestBehavior == JsonRequestBehavior.DenyGet &&
                "GET".Equals(context.HttpContext.Request.HttpMethod, StringComparison.OrdinalIgnoreCase)
                , new InvalidOperationException("GET access is not allowed.  Change the JsonRequestBehavior if you need GET access."));
            var response = context.HttpContext.Response;
            
            response.ContentType = string.IsNullOrEmpty(ContentType) ? "application/json" : ContentType;
            Check.ExecuteIfTrue(ContentEncoding != null, () => { response.ContentEncoding = ContentEncoding; });
        }

        protected virtual void SerializeData(HttpResponseBase response)
        {
            Check.ExecuteIfTrue(ErrorMessages.Any(), () =>
                {
                    Data = new
                    {
                        ErrorMessage = string.Join("\n", ErrorMessages),
                        ErrorMessages = ErrorMessages.ToArray()
                    };
                    response.StatusCode = 400;
                });
            if (Data == null) return;
            response.Write(Data.ToJson()); 
        } 

        #endregion
    }
    public class AdaptedJsonResult<T> : AdaptedJsonResult
    {
        public new T Data
        {
            get { return (T)base.Data; }
            set { base.Data = value; }
        }
    }
}