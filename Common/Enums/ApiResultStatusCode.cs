using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
S
namespace WebFramework.Api
{
    public enum ApiResultStatusCode
    {
        [Display(Name="its success full")]
        Success=200,
        [Display(Name="error in system")]
        ServerError = 503,
        [Display(Name="wrong request")]
        BadRequest = 400,
        [Display(Name="error not found")]
        NotFound= 404
    }
}
