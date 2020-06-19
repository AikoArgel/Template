using System.Collections.Generic;
using Template.Models;

namespace Template.DataAccess.WriteServices
{
    public class WriteServicesUsers : BaseServices
    {
        private TemplateEntities TemplateEntities_;
        public void AddUser(Users users)
        {
            #region AddUser without Entity
            //var SQLConnection_ = new SQLConnection();

            //var listParam = new List<BaseParamSQL>(){
            //        new BaseParamSQL()
            //        {
            //            Key = "UserName",
            //            Value = users.UserName,
            //            LenType = 50,
            //            Type = BaseParamSQL.AllType.VarChar
            //        },
            //        new BaseParamSQL()
            //        {
            //            Key = "Password",
            //            Value = users.Password,
            //            LenType = 50,
            //            Type = BaseParamSQL.AllType.VarChar
            //        },
            //        new BaseParamSQL()
            //        {
            //            Key = "Email",
            //            Value = users.Email,
            //            LenType = 150,
            //            Type = BaseParamSQL.AllType.VarChar
            //        }
            //    };
            //var model = new BaseDataSQL()
            //{
            //    Cmd = "[dbo].[AddUser]",
            //    CmdType = BaseDataSQL.AllCmdType.SP,
            //    Param = listParam

            //};
            //SQLConnection_.SendSQL(model);
            #endregion
            TemplateEntities_ = new TemplateEntities();
            TemplateEntities_.AddUser(users.UserName, users.Password, users.Email);
            TemplateEntities_.SaveChanges();
        }
        public void UpdateUser(Users users)
        {
            #region UpdateUser without Entity
            //var SQLConnection_ = new SQLConnection();

            //var listParam = new List<BaseParamSQL>(){
            //        new BaseParamSQL()
            //        {
            //            Key = "UserID",
            //            Value = users.UserID,
            //            Type = BaseParamSQL.AllType.Int
            //        },
            //        new BaseParamSQL()
            //        {
            //            Key = "UserName",
            //            Value = users.UserName,
            //            LenType = 50,
            //            Type = BaseParamSQL.AllType.VarChar
            //        },
            //        new BaseParamSQL()
            //        {
            //            Key = "Password",
            //            Value = users.Password,
            //            LenType = 50,
            //            Type = BaseParamSQL.AllType.VarChar
            //        },
            //        new BaseParamSQL()
            //        {
            //            Key = "Email",
            //            Value = users.Email,
            //            LenType = 150,
            //            Type = BaseParamSQL.AllType.VarChar
            //        },
            //        new BaseParamSQL()
            //        {
            //            Key = "Available",
            //            Value = users.Available,
            //            Type = BaseParamSQL.AllType.Bit
            //        }
            //    };
            //var model = new BaseDataSQL()
            //{
            //    Cmd = "UpdUser",
            //    CmdType = BaseDataSQL.AllCmdType.SP,
            //    Param = listParam

            //};
            //SQLConnection_.SendSQL(model);
            #endregion
            TemplateEntities_ = new TemplateEntities();
            TemplateEntities_.UpdUser(users.UserID,users.UserName, users.Password, users.Email,users.Available);
            TemplateEntities_.SaveChanges();

        }
        public void DeleteUser(Users users)
        {
            #region UpdateUser without Entity
            //var SQLConnection_ = new SQLConnection();

            //var listParam = new List<BaseParamSQL>(){
            //        new BaseParamSQL()
            //        {
            //            Key = "UserID",
            //            Value = users.UserID,
            //            Type = BaseParamSQL.AllType.Int
            //        }
            //    };
            //var model = new BaseDataSQL()
            //{
            //    Cmd = "RmvUser",
            //    CmdType = BaseDataSQL.AllCmdType.SP,
            //    Param = listParam

            //};
            //SQLConnection_.SendSQL(model);
            #endregion
            TemplateEntities_ = new TemplateEntities();
            TemplateEntities_.RmvUser(users.UserID);
            TemplateEntities_.SaveChanges();
        }
    }
}
