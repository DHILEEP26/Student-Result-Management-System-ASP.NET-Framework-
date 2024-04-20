using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Students_Record_Management_System.Common
{
    public class DataGateway
    {
        public bool ConnectToDatabase(ref Database objDB, ref string errorMessage)
        {
            bool ConnectToDatabaseRet = default;
            bool result;
            try
            {
                DatabaseFactory.SetDatabaseProviderFactory(new DatabaseProviderFactory(), false);
                objDB=DatabaseFactory.CreateDatabase("CollSqlServer");
                result = true;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message.ToString();
                result = false;
            }
            ConnectToDatabaseRet = result;
            return ConnectToDatabaseRet;
        }
    }
}
