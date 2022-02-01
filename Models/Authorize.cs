namespace Chaya.Models
{
    public class Authorize
    {
        public int AuthorizeId { get; set; }
        public string Username { get; set; }
        public string AuthPassword { get; set; }
        public string Token { get; set; }
    }
}