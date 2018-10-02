using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PMT.Models
{
    public class FeedbackForm
    {
        [Required(ErrorMessage = "* Required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "* Required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "* Required")]
        public string Mobile { get; set; }

        [Required(ErrorMessage = "* Required")]
        public string Feedback { get; set; }

        public string FormError { get; set; }
    }
}
