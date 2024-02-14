using Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WebFramework.Api
{
    public class ActionResponse<T> : IActionResponse
    {
        public ActionResponse()
        {
            Errors = new List<string>();
        }
        public int Status { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
        public ResponseStateEnum State { get; set; }
        public List<string> Errors { get; set; }
    }

    public class ValidationActionResponse<T>
    {
        public ValidationActionResponse()
        {
        }

        public T Data { get; set; }
        public ResponseStateEnum State { get; set; }
        public Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary Errors { get; set; }
    }

    public class ActionResponse : IActionResponse
    {
        public ActionResponse()
        {
            Errors = new List<string>();
        }

        public ResponseStateEnum State { get; set; }
        public List<string> Errors { get; set; }
    }

    public interface IActionResponse
    {
        ResponseStateEnum State { get; set; }
        List<string> Errors { get; set; }
    }
}
