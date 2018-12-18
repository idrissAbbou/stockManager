using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Configuration;

namespace DAL.AdoDatabaseCreatorClasses
{
    /***********************************************************************
     * kola object f database dir lih method dyalo bo7do 
     * kola method dir task wa7d la ghayr
     * fach tgadhom 3yt l kolchi f lconstructor bach tbuilda database
     * dima lfunction trad chi haja li tbyn bila dakchi tkriya f ExecuteNonQuery
       trj3 l effected lines o ila kan chi haja khas ikon fih exception trj3o
     * ila khask SqlReader declarih f lclass machi f les method kola object 
     * khaso ikon mara wa7da ila ila d3at darora ikon local
    ************************************************************************/
    public class AdoDatabaseCreator
    {
        private string _connectionString;
        private SqlConnection _sqlConnection;
        private SqlCommand _sqlCommand;

        public AdoDatabaseCreator(sqlServerTypeEnum sqlServerType)
        {
            InitializeCompenent(sqlServerType);
            Createdatabase();
        }

        private void InitializeCompenent(sqlServerTypeEnum sqlServerType)
        {
            SetConnectionString(sqlServerType);
            _sqlConnection = new SqlConnection(_connectionString);
            _sqlCommand = _sqlConnection.CreateCommand();
        }

        public void SetConnectionString(sqlServerTypeEnum sqlServerType)
        {
            switch (sqlServerType)
            {
                case sqlServerTypeEnum.sqlServer:
                    _connectionString = ConfigurationManager.ConnectionStrings["sqlConnectionString"].ConnectionString;
                    break;
                case sqlServerTypeEnum.sqlServerExpress:
                    _connectionString = ConfigurationManager.ConnectionStrings["sqlExpressConnectionString"].ConnectionString;
                    break;
                default:
                    throw new ServerNotSupportedException();
            }
        }

        public int Createdatabase()
        {
            int lineEffected = 0;
            _sqlCommand.CommandText = "create database StockManager";
            _sqlConnection.Open();
            lineEffected = _sqlCommand.ExecuteNonQuery();
            _sqlConnection.Close();
            return lineEffected;
        }

        
    }
}
