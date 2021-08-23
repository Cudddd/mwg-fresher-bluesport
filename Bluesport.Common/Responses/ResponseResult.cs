using System;

namespace Bluesport.Common.Responses
{
    public class ResponseResult
    {
        public int code { get; set; }
        // user
        public string messageTitle { get; set; }
        public string message { get; set; }
        // dev
        public string errorMessage { get; set; }
        public dynamic data { get; set; }

        public ResponseResult()
        {
            //success
            code = 0;
            messageTitle = null;
            message = null;
            errorMessage = null;
            data = null;
        }

        public void NotFoundResult(string name)
        {
            this.code = 1;
            this.messageTitle = String.Format("Không tìm thấy {0}",name);
            this.message = String.Format("Không tìm thấy {0}", name);
            this.errorMessage = String.Format("Cannot find {0}", name);
        }

        public void BadRequestResult(string name)
        {
            this.code = 1;
            this.messageTitle = String.Format("{0} không hợp lệ",name);
            this.message = String.Format("{0} không hợp lệ",name);
            this.errorMessage = String.Format("{0} is invalid",name);
        }
    }
}