using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace MyToDoList.Pages
{
    public class IndexModel : PageModel
    {

        [FromForm]
        public Models.RegisterDetails AddTask { get; set; }



        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {

            _logger = logger;
        }

        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                return;
            }
            else
            { 
                try
                {
                    if(AddTask.DoB >= DateTime.Now){
                        
                        return;
                    }

                    Redirect("~/Welcome");
                }
                catch (Exception e) { Console.WriteLine(e.Message); }
            }
        }
    }
}
