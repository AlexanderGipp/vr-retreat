﻿using System.ComponentModel.DataAnnotations;

namespace VrRetreat.WebApp.Models
{
    public class UserSettingsModel
    {

        [Required(ErrorMessage = "Old Password is required")]
        [DataType(DataType.Password)]
        public string CurrentPassword { get; set; } = string.Empty;

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; } = string.Empty;


    }
}
