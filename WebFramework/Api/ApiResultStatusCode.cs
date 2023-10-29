using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebFramework.Api
{
    public enum ApiResultStatusCode
    {
        Success=200,
        ServerError=503,
        BadRequest=400,
        NotFound=404
    }
}
