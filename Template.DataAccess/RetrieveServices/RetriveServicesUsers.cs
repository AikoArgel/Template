using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Template.Models;

namespace Template.DataAccess.RetriveServices
{
    public class RetriveServicesUsers : BaseServices
    {

        private TemplateEntities TemplateEntities_;
        private List<Users> ListUsers_;
        private Users Users_;

        public List<Users> GetAllUsers()
        {
            #region GetAllUsers without Entity
            //    var SQLConnection_ = new SQLConnection();
            //    var listParam = new List<BaseParamSQL>();
            //    var model = new BaseDataSQL()
            //    {
            //        Cmd = "[dbo].[GetAllUsers]",
            //        CmdType = BaseDataSQL.AllCmdType.SP,
            //        Param = listParam
            //    };
            //    var User = ChangeToModel(SQLConnection_.SendSQL(model), ModelsName.Users);
            //    return User;
            #endregion

            ListUsers_ = new List<Users>();
            TemplateEntities_ = new TemplateEntities();
            var users = TemplateEntities_.GetAllUsers();
            foreach (var user in users)
            {
                ListUsers_.Add(new Users()
                { 
                    UserID = user.UserID,
                    UserName = user.UserName,
                    Email = user.Email,
                    Password = user.Password,
                    LastUpdated = user.LastUpdated,
                    Available = user.Available
                });
            }
            return ListUsers_;
        }


        public Users GetUserById(int id)
        {
            #region GetUserById without Entity
            //var SQLConnection_ = new SQLConnection();

            //var model = new BaseDataSQL()
            //{
            //    Cmd = "SELECT * FROM [Users] WHERE [UserID] = " + id + ";",
            //    CmdType = BaseDataSQL.AllCmdType.TSql,
            //    Param = null

            //};
            //return ChangeToModel(SQLConnection_.SendSQL(model), BaseServices.ModelsName.Users);
            #endregion

            TemplateEntities_ = new TemplateEntities();
            var users = TemplateEntities_.GetUserByID(id).FirstOrDefault();
            Users_ = new Users()
            {
                UserID = users.UserID,
                UserName = users.UserName,
                Email = users.Email,
                Available = users.Available
            };
            return Users_;

        }
        public Users GetUserByEmail(string email)
        {
            var SQLConnection_ = new SQLConnection();
            var listParam = new List<BaseParamSQL>(){
                    new BaseParamSQL()
                    {
                        Key = "Email",
                        Value = email,
                        LenType = 150,
                        Type = BaseParamSQL.AllType.VarChar
                    }
                };
            var model = new BaseDataSQL()
            {
                Cmd = "[dbo].[GetUserByEmail]",
                CmdType = BaseDataSQL.AllCmdType.SP,
                Param = listParam

            };
            var User = ChangeToModel(SQLConnection_.SendSQL(model), ModelsName.User);
            return User;
        }
        public Users GetUserLogin(string user, string password)
        {
            var SQLConnection_ = new SQLConnection();
            var listParam = new List<BaseParamSQL>(){
                    new BaseParamSQL()
                    {
                        Key = "User",
                        Value = user,
                        LenType = 150,
                        Type = BaseParamSQL.AllType.VarChar
                    },
                    new BaseParamSQL()
                    {
                        Key = "Password",
                        Value = password,
                        LenType = 50,
                        Type = BaseParamSQL.AllType.VarChar
                    }
                };
            var model = new BaseDataSQL()
            {
                Cmd = "[dbo].[GetUserLogin]",
                CmdType = BaseDataSQL.AllCmdType.SP,
                Param = listParam

            };
            var User = ChangeToModel(SQLConnection_.SendSQL(model), ModelsName.User);
            return User;
        }
    }
}