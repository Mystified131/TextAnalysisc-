using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCApplication.ViewModels
{

    public class ResultViewModel
    {
        [Required]
        public string content { get; set; }
        public Dictionary<string, int> retDict { get; set; }
        public String Error { get; set; }
    }
}


