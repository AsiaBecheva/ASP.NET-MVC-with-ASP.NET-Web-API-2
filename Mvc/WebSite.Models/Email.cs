namespace WebSite.Models
{
    using System;

    public class Email   // Maybe unnecessary database model
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public string Phone { get; set; }

        public string Url { get; set; }
        
        public string Company { get; set; }
        
        public string Subject { get; set; }
        
        public string Message { get; set; }
    }
}
