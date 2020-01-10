using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Users.Areas.User.Pages.Account
{
    public class RegisterModel : PageModel
    {
        public String Message { get; set; }
        public void OnGet(String data)
        {
            Message = data;
        }
    }
}
