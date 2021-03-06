using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Users.Areas.User.Pages.Account
{
    public class RegisterModel : PageModel
    {
        //public String Message { get; set; }
        //public void OnGet(String data)

        private UserManager<IdentityUser> _userManager;

        public RegisterModel(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        public void OnGet()
        {
            //Message = data;
        }
        
        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Required(ErrorMessage = "The Email field is Required!")]
            [EmailAddress]
            [Display(Name = "Email")]
            public String Email { get; set; }

            [Required(ErrorMessage = "The Password field is Required!")]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            [StringLength(100, ErrorMessage = "The number of characters in {0} must be at least {2}", MinimumLength = 6)]
            public String Password { get; set; }

            [Required(ErrorMessage = "The Confirm Password field is requiered!")]
            [DataType(DataType.Password)]
            [Display(Name = "Confirm Password")]
            [Compare("Password", ErrorMessage = "The Password and Confirmation Password do not match.")]
            public String ConfirmPassword { get; set; }

            //[Required]
            public String ErrorMessage { get; set; }
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var userList = _userManager.Users.Where(u => u.Email.Equals(Input.Email)).ToList();
                if (userList.Count.Equals(0))
                {
                    var result = await _userManager.CreateAsync(user, Input.Password);
                }
                else
                {
                    Input = new InputModel
                    {
                        ErrorMessage = "El " + Input.Email + " ya esta registrado",
                    };

                }
            }
            //else
            //{
            //    // Se pasa como parametro el nombre del Span
            //    ModelState.AddModelError("Input.Email", "Se ha generado un error en el Servidor");
            //}
            //var data = Input;
            return Page();
        }
    }
}
