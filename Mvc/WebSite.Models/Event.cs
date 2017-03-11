namespace WebSite.Models
{
    using System;

    public class Event
    {
        public int Id { get; set; }

        public string Topic { get; set; }

        public DateTime HeldOn { get; set; }

        public string Description { get; set; }
    }
}
