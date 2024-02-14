using Common.Enums;

namespace MyApi.Models.Responses
{
    public class ActionResponse<T> : IActionResponse
    {
        public ActionResponse()
        {
            Errors = new List<string>();
        }

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
