﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;

namespace WebBatDongSan_ver2.Extension
{
    public static class IdentityExtension
    {
        public static string GetAccountID(this IIdentity identity)
        {
            var claim = ((ClaimsIdentity)identity).FindFirst("AccountId");
            return (claim != null) ? claim.Value : string.Empty;
        }
        

        public static string GetRoleID (this IIdentity identity)
        {
            var claim = ((ClaimsIdentity)identity).FindFirst("RoleId");
            return (claim != null) ? claim.Value : string.Empty;


        }

        public static string GetSpecificClaim(this ClaimsPrincipal claimsPrincipal, string claimType)
        {
            var claim = claimsPrincipal.Claims.FirstOrDefault(x => x.Type == claimType);
            return (claim != null) ? claim.Value : string.Empty;
        }
    }
}
