﻿
using System.ComponentModel.DataAnnotations;

namespace Academy.Domain.ViewModels.Account
{
    public class ChangeUserPasswordViewModel
    {
        [Display(Name = "کلمه عبور فعلی")]
        [MaxLength(50, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{6,20}$", ErrorMessage = "کلمه عبور باید شامل حرف و عدد باشد")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "{0} نمیتواند کمتر از 6 کاراکتر داشته باشد ")]
        public string OldPassword { get; set; }
        [Display(Name = "کلمه عبور جدید")]
        [MaxLength(50, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{6,20}$", ErrorMessage = "کلمه عبور باید شامل حرف و عدد باشد")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "{0} نمیتواند کمتر از 6 کاراکتر داشته باشد ")]
        public string Password { get; set; }

        [Display(Name = "تکرار کلمه عبور جدید")]
        [MaxLength(50, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "کلمه های عبور مغایرت دارند")]
        public string ConfirmPassword { get; set; }
    }

    public enum ChangeUserPasswordResult
    {
        OldPasswordIsWrong,
        Success
    }
}
