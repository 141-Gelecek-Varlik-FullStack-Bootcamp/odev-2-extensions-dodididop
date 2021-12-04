using System;
using System.ComponentModel.DataAnnotations;

namespace Extensions
{
    public enum UserType//enum created for creating user type.
    {
        [Display(Name ="User")]
        UserType1 = 1,
        [Display(Name = "Manager")]
        UserType2 = 2,

    }
}
