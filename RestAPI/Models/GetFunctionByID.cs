using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestAPI.Models
{
    public class GetFunctionByID
    {
        [Key]
        public Guid? FunctionByID { get; set; }
        public string Values { get; set; }
        // All the other properties.
    }
}