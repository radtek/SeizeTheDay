﻿using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SeizeTheDay.Core.Entities;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SeizeTheDay.Core.Domain.Identity
{
    public class AppUser : IdentityUser<int, AppUserLogin, AppUserRole, AppUserClaim>
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<AppUser, int> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<AppUser, int> manager, string authenticationType)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity2 = await manager.CreateIdentityAsync(this, authenticationType);
            // Add custom user claims here
            return userIdentity2;
        }

        /// <summary>
        /// Gets or sets user detail Id
        /// </summary>
        public int UserDetailId { get; set; }

        /// <summary>
        /// Gets the user detail
        /// </summary>
        public virtual AppUserDetail UserDetail { get; set; }
    }
}
