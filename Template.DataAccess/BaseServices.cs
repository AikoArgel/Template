using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Template.Models;

namespace Template.DataAccess
{
    public class BaseServices
    {
        protected dynamic ChangeToModel(List<DataRow> dataRows, ModelsName modelName)
        {
            switch (modelName)
            {
                case ModelsName.User: return GetUser(dataRows.FirstOrDefault());
                case ModelsName.Users: return GetListUsers(dataRows);
                default: break;
            }
            return null;
        }

        protected enum ModelsName
        {
            User,
            Users
        }

        private Users GetUser(DataRow row)
        {
            if (row == null) throw new Exception("Not exist user into DB");
            return new Users()
            {
                UserID = row["UserID"] == null ? 0 : row.Field<int>("UserID"),
                UserName = row["UserName"] == null ? null : row.Field<string>("UserName"),
                Password = "*******",
                Email = row["Email"] == null ? null : row.Field<string>("Email"),
                LastUpdated = row["LastUpdated"] == null ? DateTime.Now : row.Field<DateTime>("LastUpdated"),
                Available = row["Available"] == null ? false : row.Field<bool>("Available")
            };
        }

        private List<Users> GetListUsers(List<DataRow> dataRows)
        {
            var list = new List<Users>();
            foreach (var data in dataRows)
            {
                list.Add(GetUser(data));
            }
            return list;
        }
    }
}
