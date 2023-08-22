using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebFramework.Api
{
    public enum ApiResultStatusCode
    {
        Success,
        ServerError,
        BadRequest,
        NotFound,
        ListEmpty
    }
}
