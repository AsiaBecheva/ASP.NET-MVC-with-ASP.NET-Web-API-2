namespace WebSite.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using WebSite.Infrastructure.Constants;

    public class Email   // Maybe unnecessary database model
    {
        public int Id { get; set; }

        [Required]
        [MinLength(ValidationConstants.MinLengthEmailName)]
        [MaxLength(ValidationConstants.MaxLengthEmailName)]
        public string Name { get; set; }

        [DataType(DataType.Url, ErrorMessage = "Invalid URL")]
        public string Phone { get; set; }

        [DataType(DataType.PhoneNumber, ErrorMessage = "Invalid Phone number")]
        public string Url { get; set; }

        [MinLength(ValidationConstants.MinLengthEmailCompany)]
        [MaxLength(ValidationConstants.MaxLengthEmailCompany)]
        public string Company { get; set; }

        [Required]
        [MinLength(ValidationConstants.MinLengthEmailSubject)]
        [MaxLength(ValidationConstants.MaxLengthEmailSubject)]
        public string Subject { get; set; }

        [Required]
        [MinLength(ValidationConstants.MinLengthEmailMessage)]
        [MaxLength(ValidationConstants.MaxLengthEmailMessage)]
        public string Message { get; set; }

        internal void SendMessage()
        {
            throw new EntryPointNotFoundException();
        }
    }
}
