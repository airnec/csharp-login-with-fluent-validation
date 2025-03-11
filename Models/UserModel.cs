﻿using System.ComponentModel.DataAnnotations;

namespace CSharpLoginWithFluentValidation.Models
{
    public class UserModel
    {
        public string Email { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;
    }
}
