using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Data.Entity;
//using System.Data.Entity.Validation;
//using System.Data.Entity.Infrastructure;
using System.Data;
using System.Globalization;

namespace Asp.Identity.Oracle
{
    public static class DataHelper
    {
        public const string BoolYNTue = "Y";
        public const string BoolYNFalse = "N";

        public static bool BoolYN(string flag)
        {
            return ((flag != null) && flag.Equals(BoolYNTue));
        }

        public static string BoolYNStr(bool active)
        {
            if (active)
            { return BoolYNTue; }
            else
            { return BoolYNFalse; }
        }
    }

    public partial class IdentityDbContext : IDisposable //: DbContext
    {
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // free managed resources
            }
        }
        //public IdentityDbContext(string connectionString)
        //    : base(connectionString)
        //{
        //}

        //public async Task<TResult> WaitResult<TResult>(Func<TResult> function)
        //{
        //    return await Task<TResult>.Run(function);
        //}

        // entity framework 5 Async save
        public async Task<int> SaveEF5ChangesAsync()
        {
            //return await Task.Run(() => this.SaveChanges());
            return await Task.FromResult(1);
        }

        /// <summary>
        ///     If true validates that emails are unique
        /// </summary>
        public bool RequireUniqueEmail { get; set; }

        //protected override DbEntityValidationResult ValidateEntity(DbEntityEntry entityEntry,
        //    IDictionary<object, object> items)
        //{
        //    if (entityEntry != null && entityEntry.State == EntityState.Added)
        //    {
        //        var errors = new List<DbValidationError>();
        //        var user = entityEntry.Entity as IdentityUser;// TUser;
        //        //check for uniqueness of user name and email
        //        if (user != null) 
        //        {

        //            var dupNamed = from u in Users select u;
        //            dupNamed = (user.UserName == null) ? dupNamed.Where(u => u.UserName == null) : dupNamed.Where(u => u.UserName.ToUpper() == user.UserName.ToUpper());
        //            var any = dupNamed.Any();
        //            if (any)
        //            {
        //                errors.Add(new DbValidationError("User", String.Format(CultureInfo.CurrentCulture, IdentityResources.DuplicateUserName, user.UserName)));
        //            }

        //            var dupEmail = from u in Users select u;
        //            dupEmail = (user.Email == null) ? dupEmail.Where(u => u.Email == null) : dupEmail.Where(u => u.Email.ToUpper() == user.Email.ToUpper());
        //            var anyEmail = dupEmail.Any();
        //            if (anyEmail)
        //            {
        //                errors.Add(new DbValidationError("User",
        //                    String.Format(CultureInfo.CurrentCulture, IdentityResources.DuplicateEmail, user.Email)));
        //            }
        //        }
        //        else
        //        {
        //            var role = entityEntry.Entity as IdentityRole; // TRole;
        //            if (role != null)
        //            {
        //                //check for uniqueness of role name
        //                var dupRoles = from u in Roles select u;
        //                dupRoles = (role.Name == null) ? dupRoles.Where(r => r.Name == null) : dupRoles.Where(r => r.Name.ToUpper() == role.Name.ToUpper());
        //                var anyRoles = dupRoles.Any();
        //                if (anyRoles)
        //                {
        //                    errors.Add(new DbValidationError("Role",
        //                        String.Format(CultureInfo.CurrentCulture, IdentityResources.RoleAlreadyExists, role.Name)));
        //                }
                        
        //            }
        //        }
        //        if (errors.Any())
        //        {
        //            return new DbEntityValidationResult(entityEntry, errors);
        //        }
        //    }
        //    return base.ValidateEntity(entityEntry, items);
        //}

        /// <summary>
        /// stub properties
        /// </summary>
 
        public List<IdentityRole> Roles { get {
            List<IdentityRole> list = new List<IdentityRole>
            {
                new IdentityRole {
                    Id = "1234",
                    Name = "Admin"
                }
            };
            return list;
        }  }


        public List<IdentityUser> Users
        {
            get
            {
                List<IdentityUser> list = new List<IdentityUser>
                {
                    new IdentityUser
                    {
                        Id = "8b76d0ae-d40c-4e5e-a592-be69d0f94374",
                        UserName = "admin@example.com",
                        PasswordHash = "ABTx0ENQPhlDoH0iSiMww1E7cP0IGcmDIDqg+uhPT/qwed7nGmICn+MZ1Q4pOsBePQ==",
                        SecurityStamp = "0e088c6e-a954-4d8a-9375-112789311803",
                        Roles = new List<IdentityRole>
                        {
                            new IdentityRole {
                                Id = "1234",
                                Name = "Admin"
                            }
                        }
                    }
                };


                return list;
            }
        }

        public List<IdentityUserLogin> Logins
        {
            get
            {
                List<IdentityUserLogin> list = new List<IdentityUserLogin>();
                return list;
            }
        }

        public List<IdentityUserClaim> Claims
        {
            get
            {
                List<IdentityUserClaim> list = new List<IdentityUserClaim>();
                return list;
            }
        }


        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
