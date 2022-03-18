using System.Net;

namespace SchoolExampleAPI.Model.DTOs
{
    public class ResponseObject
    {
        public string Response { get; set; }
        public HttpStatusCode Status { get; set; } = HttpStatusCode.NoContent;
    }
}