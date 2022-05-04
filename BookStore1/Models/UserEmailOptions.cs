namespace BookStore1.Models
{
    public class UserEmailOptions
    {
        public List<string> ToEmail { get; set; }   
        public string Subject { get; set; }
        public string Body { get; set; }
        public List<KeyValuePair<string, string>> PlaceHolder { get; set; }
    }
}
