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
        }
    }
}
