using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

using Microsoft.Extensions.Configuration;

namespace webapp.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;
        public string para1 = "";

        public PrivacyModel(ILogger<PrivacyModel> logger, IConfiguration config)
        {
            _logger = logger;
            para1 = config.GetSection("myConfig:para1").Value;
        }

        public void OnGet()
        {
        }
    }
}
