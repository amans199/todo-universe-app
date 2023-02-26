using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace TodoUniverse.Library;
public static class UserExtensions
{
    //get user id from claims
    public static int GetUserId(this IPrincipal user)
    {
        var identity = user.Identity as ClaimsIdentity;
        string userId = identity.FindFirst(ClaimTypes.NameIdentifier)?.Value;

        if (userId ==null)
        {
            return  0;
        }
        return int.Parse(userId);
    }
}
