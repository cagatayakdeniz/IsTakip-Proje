﻿using System;
using System.Collections.Generic;
using System.Text;

namespace IsTakipProject.Entities.DTOs.AppUserDtos
{
    public class AppUserAddDto
    {
        //[Required(ErrorMessage = "UserName Alanı Boş Geçilemez.")]
        public string UserName { get; set; }
        //[Required(ErrorMessage = "Password Alanı Boş Geçilemez.")]
        //[DataType(DataType.Password)]
        public string Password { get; set; }
        //[Compare("Password", ErrorMessage = "Parolalar Eşleşmiyor")]
        //[DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
        //[Required(ErrorMessage = "Email Alanı Boş Geçilemez.")]
        public string Email { get; set; }
        //[Required(ErrorMessage = "Name Alanı Boş Geçilemez.")]
        public string Name { get; set; }
        //[Required(ErrorMessage = "Surname Alanı Boş Geçilemez.")]
        public string Surname { get; set; }
    }
}
