﻿using System.ComponentModel.DataAnnotations;

namespace Mock_interview.Mock_InterviewServiceTools.Attributes
{
    public class UserPassword : ValidationAttribute
    {
        public override bool IsValid(object value)
           => value is string password &&
               password.Length >= 8 &&
                   password.Any(c => char.IsDigit(c)) &&
                       password.Any(c => char.IsLetter(c));
    }
}
