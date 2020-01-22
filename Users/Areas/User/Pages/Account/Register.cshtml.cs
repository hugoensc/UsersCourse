using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace Users.Areas.User.Pages.Account
{
    public class RegisterModel : PageModel
    {
        //public String Message { get; set; }
        //public void OnGet(String data)
        public void OnGet()
        {
            //Message = data;
        }
        
        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public String Email { get; set; }

            [Required]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            [StringLength(100, ErrorMessage = "The number of characters in {0} must be at least {2}", MinimumLength = 6)]
            public String Password { get; set; }

            [Required]
            [DataType(DataType.Password)]
            [Display(Name = "Confirm Password")]
            [Compare("Password", ErrorMessage = "The Password and Confirmation Password do not match.")]
            public String ConfirmPassword { get; set; }
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {

            }
            var data = Input;
            return Page();
        }
    }
}
