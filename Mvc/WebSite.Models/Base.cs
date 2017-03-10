namespace WebSite.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public abstract class Base
    {
        [DataType(DataType.Date)]
        public DateTime CreatedOn { get; set; }
    }
}
