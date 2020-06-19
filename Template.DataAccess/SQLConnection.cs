using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Configuration;

namespace Template.DataAccess
{
    #region Class SQL
    /// <summary>
    /// SQLConnection is a simple connection with two form to send information.
    /// <para>for T-SQL or Stored Procedure. This version is the 1.0.0.0</para>
    /// <para>coming soon v1.1.0.0 with better render</para>
    /// </summary>
    public class SQLConnection
    {
        private SqlConnection SqlConn_;
        private SqlDataAdapter SqlDataAdapter_;
        private DataTable DataTable_;
        private readonly string StrConn_ = "Server=[SVR];Database=[DB];";
        private readonly string StrSqlConn_ = "User Id=[USR];Password=[PWD];";
        private readonly string StrWinConn_ = "Trusted_Connection=True;";
        private readonly string Svr_, Db_, Usr_, Pwd_;
        private readonly string StringConnection = ConfigurationManager.ConnectionStrings[1]?.ConnectionString;
        private readonly bool Win_;
        private readonly int TryMax = 3;
        private int TryCurrent = 0;

        #region SQLConnection constructor without params to create connect
        public SQLConnection()
        {

        }
        #endregion
        #region SQLConnection constructor with params to create connect
        /// <summary>
        /// Constructor Set variable to create connection automaticly.
        /// NOTE: This function is only for SQL Server, 
        /// </summary>
        /// <param name="_svr">Set Servidor to connect</param>
        /// <param name="_db">Set DataBase to connect</param>
        /// <param name="_win">Set two options.
        /// <para>Set true if is with autentication Windows</para>
        /// <para>Set false if is with autentication SQL Server</para>
        /// <para>NOTE: This options is true for default.</para>
        /// <param name="_usr">Set User if exist to connect</param>
        /// <param name="_pwd">Set Password if exist to connect</param>
        /// </param>
        public SQLConnection(string _svr, string _db, bool _win = true, string _usr = null, string _pwd = null)
        {
            Svr_ = _svr;
            Db_ = _db;
            Usr_ = _usr;
            Pwd_ = _pwd;
            Win_ = _win;
        }
        #endregion
        #region SendSQL
        /// <summary>
        /// This function is for send command or SP to SQL Server.
        /// </summary>
        /// <param name="_model">Set any model of type BaseDataSQL</param>
        /// <returns></returns>
        public List<DataRow> SendSQL(BaseDataSQL _model)
        {
            try
            {
                InitConnection();
                DataTable_ = new DataTable();
                if (SQLOpen())
                {
                    using (SqlDataAdapter_ = new SqlDataAdapter())
                    {
                        SqlDataAdapter_.SelectCommand = new SqlCommand(_model.Cmd, SqlConn_);
                        SqlDataAdapter_ = SetCommandType(SqlDataAdapter_, (int)_model.CmdType);
                        SqlDataAdapter_ = SetParameters(SqlDataAdapter_, _model.Param);
                        SqlDataAdapter_.Fill(DataTable_);
                    }
                    SQLClose();
                }
                return DataTable_.AsEnumerable().ToList();
            }
            finally
            {
                EndConnection();
            }
        }
        #endregion
        #region SetCommandType
        private SqlDataAdapter SetCommandType(SqlDataAdapter _sqlDataAdapter, int CmdType)
        {
            switch (CmdType)
            {
                case 0: _sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure; break;
                case 1: _sqlDataAdapter.SelectCommand.CommandType = CommandType.Text; break;
                default: throw new Exception("CmdType not is of type SP or TSQL");
            }
            return _sqlDataAdapter;
        }
        #endregion
        #region SetParameters and childrens
        private SqlDataAdapter SetParameters(SqlDataAdapter _sqlDataAdapter, List<BaseParamSQL> _param)
        {
            if (_param == null) return SqlDataAdapter_;
            foreach (var m in _param)
            {
                if (TypesWithoutLenType((int)m.Type)) _sqlDataAdapter.SelectCommand.Parameters.Add("@" + m.Key, SelectType((int)m.Type), m.LenType).Value = m.Value;
                else _sqlDataAdapter.SelectCommand.Parameters.Add("@" + m.Key, SelectType((int)m.Type)).Value = m.Value;
            }
            return _sqlDataAdapter;
        }
        #region TypesWithoutLenType
        /// <summary>
        /// This function decided if this type need sen len or not.
        /// </summary>
        /// <param name="_type">int of type AllType into Model MSqlDataAdapterParam</param>
        /// <returns></returns>
        private bool TypesWithoutLenType(int _type)
        {
            switch (_type)
            {
                case 0: // Bit
                case 1: // Binary
                case 3: // TinyInt
                case 4: // SmallInt
                case 5: // Int
                case 6: // BigInt
                case 7: // Float
                case 8: // SmallMoney
                case 9: // Money
                case 14: // NText
                case 15: // Text
                case 16: // Time
                case 17: // SmallDateTime
                case 18: // Date
                case 19: // DateTime
                case 20: // Image
                case 21: // Xml
                case 22: return false; // Guid
                default: break;
            }
            return true;
        }
        #endregion
        #region SelectType
        /// <summary>
        /// This function select type of MSqlDataAdapterParam of variable 'Type' and return one of type SqlDbType
        /// </summary>
        /// <param name="_type"></param>
        /// <returns></returns>
        private SqlDbType SelectType(int _type)
        {
            switch (_type)
            {
                case 0: return SqlDbType.Bit;
                case 1: return SqlDbType.Binary;
                case 2: return SqlDbType.VarBinary;
                case 3: return SqlDbType.TinyInt;
                case 4: return SqlDbType.SmallInt;
                case 5: return SqlDbType.Int;
                case 6: return SqlDbType.BigInt;
                case 7: return SqlDbType.Float;
                case 8: return SqlDbType.SmallMoney;
                case 9: return SqlDbType.Money;
                case 10: return SqlDbType.Char;
                case 11: return SqlDbType.NChar;
                case 12: return SqlDbType.NVarChar;
                case 13: return SqlDbType.VarChar;
                case 14: return SqlDbType.NText;
                case 15: return SqlDbType.Text;
                case 16: return SqlDbType.Time;
                case 17: return SqlDbType.SmallDateTime;
                case 18: return SqlDbType.Date;
                case 19: return SqlDbType.DateTime;
                case 20: return SqlDbType.Image;
                case 21: return SqlDbType.Xml;
                case 22: return SqlDbType.UniqueIdentifier;
                default: break;
            }
            throw new Exception("The param Type into model 'MSqlDataAdapterParam' no is correct");
        }
        #endregion
        #endregion
        #region Open or close connection
        private bool SQLOpen()
        {
            SqlConn_ = new SqlConnection(GetConnectionString());
            SqlConn_.Open();
            if (SqlConn_ != null && SqlConn_.State == ConnectionState.Closed) TryAgain(true, "No connect with server ");
            return true;
        }
        private void SQLClose()
        {
            SqlConn_.Close();
            if (SqlConn_ != null && SqlConn_.State == ConnectionState.Open) TryAgain(false, "No disconnect with server ");
        }
        private void TryAgain(bool _openConnection, string _msgError)
        {
            TryCurrent++;
            if (TryCurrent == TryMax) throw new Exception(_msgError + Svr_ + ", Check and try again");
            if (_openConnection) SQLOpen();
            else SQLClose();
        }
        #endregion        
        #region Connection String
        private string GetConnectionString()
        {
            if (StringConnection != null) return StringConnection;
            if (Win_) return StrConn_.Replace("[SVR]", Svr_).Replace("[DB]", Db_) + GetConnWithWin();
            return StrConn_.Replace("[SVR]", Svr_).Replace("[DB]", Db_) + GetConnWithSql(Usr_, Pwd_);
        }
        private string GetConnWithSql(string _usr, string _pwd) => StrSqlConn_.Replace("[USR]", _usr).Replace("[PWD]", _pwd);
        private string GetConnWithWin() => StrWinConn_;
        #endregion
        #region Configuration to init or finish connection.
        private void InitConnection()
        {
            TryCurrent = 0;
            if (SqlConn_ != null) SqlConn_.Close();
            SqlConn_ = null;
        }
        private void EndConnection()
        {
            TryCurrent = 0;
            if (SqlConn_ != null) SqlConn_.Close();
            SqlConn_ = null;
        }
        #endregion
    }
    #endregion
    #region Models to SQL Class
    public class BaseDataSQL
    {
        /// <summary>
        /// Only set command type T-SQL or Name of SP
        /// <para>Example T-SQL -></para>
        /// <para>SELECT *</para>
        /// <para>   FROM [TABLE_1]</para>
        /// <para>   INNER JOIN [TABLE_2] WITH(NOLOCK) ON [TABLE_1] = [TABLE_2]</para>
        /// <para>   WHERE [TABLE_1].[CONDITION]</para>
        /// <para>Example SP -></para>
        /// <para>up_GetTable_1</para>
        /// </summary>
        public string Cmd { get; set; }
        /// <summary>
        /// <para>Only set SP or T-SQL</para>
        /// <para>SP -> StoreProcedured.</para>
        /// <para>T-SQL Command TypeScript SQL.</para>
        /// </summary>
        public AllCmdType CmdType { get; set; }
        /// <summary>
        /// Set any List of type BaseParamSQL.
        /// </summary>
        public List<BaseParamSQL> Param { get; set; }
        /// <summary>
        /// This variable show all type command that you can used
        /// </summary>
        public enum AllCmdType
        {
            SP,
            TSql
        }
    }
    /// <summary>
    /// This class is only to connection with Stored Procedure.
    /// </summary>
    public class BaseParamSQL
    {
        /// <summary>
        /// This param is used for specific what is the name of param into Stored Procedure.
        /// <para>Example -> into SP you could be find @Id</para>
        /// <para>then you only must be write Id here.</para>
        /// </summary>
        public string Key { get; set; }
        /// <summary>
        /// This param only set with type data AllType.
        /// </summary>
        public AllType Type { get; set; }
        /// <summary>
        /// This param get the lenght used into Stored Procedure param.
        /// <para>Example -> if you have a variable the type varchar(50)</para>
        /// <para>then you only must be write 50 here.</para>
        /// </summary>
        public int LenType { get; set; }
        /// <summary>
        /// This param is used for set the value that you want send to Store Procedure.
        /// <para>Example 1 -> if you param @Name get a varchar type</para>
        /// <para>you only must be write "Jhon" in c#</para>
        /// <para>Example 2 -> if you param @Available get a bit type</para>
        /// <para>you only must be write true in c#</para>
        /// <para>Example 3 -> if you param @Id get a int type</para>
        /// <para>you only must be write 10 in c#</para>
        /// </summary>
        public dynamic Value { get; set; }
        /// <summary>
        /// This param show all type of data that SQL Server 
        /// </summary>
        public enum AllType
        {
            Bit,
            Binary,
            VarBinary,
            TinyInt,
            SmallInt,
            Int,
            BigInt,
            Float,
            SmallMoney,
            Money,
            Char,
            NChar,
            NVarChar,
            VarChar,
            NText,
            Text,
            Time,
            SmallDateTime,
            Date,
            DateTime,
            Image,
            Xml,
            Guid
        }
    }
    #endregion
}