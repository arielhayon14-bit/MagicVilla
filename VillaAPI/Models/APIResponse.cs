using System.Net;

namespace VillaAPI.Models
{
    public class APIResponse
    {
        public HttpStatusCode StatusCode { get; set; }
        public bool IsSuccess { get; set; } = true;
        public object? Result { get; set; }
        public List<string>? ErrorMessages { get; set; }
        public APIResponse()
        {
            ErrorMessages = new List<string>();
        }
    }
}
