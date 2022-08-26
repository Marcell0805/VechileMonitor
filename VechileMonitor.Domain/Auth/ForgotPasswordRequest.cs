﻿using System.ComponentModel.DataAnnotations;

namespace VechileMonitor.Domain.Auth
{
    public class ForgotPasswordRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
