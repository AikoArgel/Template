﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Template.DataAccess
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class TemplateEntities : DbContext
    {
        public TemplateEntities()
            : base("name=TemplateEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Users> Users { get; set; }
    
        public virtual int AddUser(string userName, string password, string email)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddUser", userNameParameter, passwordParameter, emailParameter);
        }
    
        public virtual ObjectResult<GetAllUsers_Result> GetAllUsers()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllUsers_Result>("GetAllUsers");
        }
    
        public virtual ObjectResult<GetUserLogin_Result> GetUserLogin(string user, string password)
        {
            var userParameter = user != null ?
                new ObjectParameter("User", user) :
                new ObjectParameter("User", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetUserLogin_Result>("GetUserLogin", userParameter, passwordParameter);
        }
    
        public virtual int RmvUser(Nullable<int> userID)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("RmvUser", userIDParameter);
        }
    
        public virtual int UpdUser(Nullable<int> userID, string userName, string password, string email, Nullable<bool> available)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(int));
    
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var availableParameter = available.HasValue ?
                new ObjectParameter("Available", available) :
                new ObjectParameter("Available", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdUser", userIDParameter, userNameParameter, passwordParameter, emailParameter, availableParameter);
        }
    
        public virtual ObjectResult<GetUserByEmail_Result> GetUserByEmail(string email)
        {
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetUserByEmail_Result>("GetUserByEmail", emailParameter);
        }
    
        public virtual ObjectResult<GetUserByID_Result> GetUserByID(Nullable<int> userID)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetUserByID_Result>("GetUserByID", userIDParameter);
        }
    }
}
