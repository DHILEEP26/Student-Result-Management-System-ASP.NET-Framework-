using System;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Web;
using System.Data;

namespace Students_Record_Management_System.Common
{
    public class DBClass
    {
        public bool GetData(ref int returnDsValue, string storedProcedureName, object[] parameters, ref string returnMessage)
        {
            returnDsValue = default;
            bool isSuccess = false;
            try
            {
                Database dtBase = default;
                var commonDataGteWay = new DataGateway();

                if (commonDataGteWay.ConnectToDatabase(ref dtBase, ref returnMessage))
                {
                    long result = 0;
                    DbCommand dbCommandQuery = dtBase.GetStoredProcCommand(storedProcedureName, parameters);
                    returnDsValue =(int)dtBase.ExecuteScalar(dbCommandQuery);
                    result = Convert.ToInt64(dtBase.GetParameterValue(dbCommandQuery, "RESULT"));
                    returnMessage = dtBase.GetParameterValue(dbCommandQuery, "RESULT_MESSAGE").ToString();
                    if (result == 0)
                    {
                        isSuccess = true;
                    }
                }
            }
            catch (Exception exception)
            {
                returnMessage = exception.ToString();
            }
            return isSuccess;
        }
        public bool GetTableData(ref DataSet returnDsValue, string storedProcedureName, object[] parameters, ref string returnMessage)
        {
            returnDsValue = default;
            bool isSuccess = false;
            try
            {
                Database dtBase = default;
                var commonDataGteWay = new DataGateway();

                if (commonDataGteWay.ConnectToDatabase(ref dtBase, ref returnMessage))
                {
                    long result = 0;
                    DbCommand dbCommandQuery = dtBase.GetStoredProcCommand(storedProcedureName, parameters);
                    returnDsValue = dtBase.ExecuteDataSet(dbCommandQuery);
                    result = Convert.ToInt64(dtBase.GetParameterValue(dbCommandQuery, "RESULT"));
                    returnMessage = dtBase.GetParameterValue(dbCommandQuery, "RESULT_MESSAGE").ToString();
                    if (result == 0)
                    {
                        isSuccess = true;
                    }
                }
            }
            catch (Exception exception)
            {
                returnMessage = exception.ToString();
            }
            return isSuccess;
        }

        public bool SaveData(string storedProcedureName, object[] parameters, ref string returnOutValue, ref string returnMessage)
        {

            bool isSuccess = false;
            try
            {
                Database dtBase = default;
                var commonDataGteWay = new DataGateway();

                if (commonDataGteWay.ConnectToDatabase(ref dtBase, ref returnMessage))
                {
                    DbCommand dbCommandQuery = dtBase.GetStoredProcCommand(storedProcedureName, parameters);
                    dtBase.ExecuteNonQuery(dbCommandQuery);
                    var result = Convert.ToInt64(dtBase.GetParameterValue(dbCommandQuery, "RESULT"));
                    returnOutValue = dtBase.GetParameterValue(dbCommandQuery, "RESULT_MESSAGE").ToString();
                    if (result == 0)
                    {
                        isSuccess = true;
                    }
                }
            }
            catch (Exception exception)
            {
                returnMessage = exception.ToString();
            }
            return isSuccess;

        }

        public bool GetImage(ref object returnDsValue, string storedProcedureName, object[] parameters, ref string returnMessage)
        {
            returnDsValue = default;
            bool isSuccess = false;
            try
            {
                Database dtBase = default;
                var commonDataGteWay = new DataGateway();

                if (commonDataGteWay.ConnectToDatabase(ref dtBase, ref returnMessage))
                {
                    long result = 0;
                    DbCommand dbCommandQuery = dtBase.GetStoredProcCommand(storedProcedureName, parameters);
                    returnDsValue =dtBase.ExecuteScalar(dbCommandQuery);
                    result = Convert.ToInt64(dtBase.GetParameterValue(dbCommandQuery, "RESULT"));
                    returnMessage = dtBase.GetParameterValue(dbCommandQuery, "RESULT_MESSAGE").ToString();
                    if (result == 0)
                    {
                        isSuccess = true;
                    }
                }
            }
            catch (Exception exception)
            {
                returnMessage = exception.ToString();
            }
            return isSuccess;
        }
        public bool GetString(ref string returnDsValue, string storedProcedureName, object[] parameters, ref string returnMessage)
        {
            returnDsValue = default;
            bool isSuccess = false;
            try
            {
                Database dtBase = default;
                var commonDataGteWay = new DataGateway();

                if (commonDataGteWay.ConnectToDatabase(ref dtBase, ref returnMessage))
                {
                    long result = 0;
                    DbCommand dbCommandQuery = dtBase.GetStoredProcCommand(storedProcedureName, parameters);
                    returnDsValue =dtBase.ExecuteScalar(dbCommandQuery).ToString();
                    result = Convert.ToInt64(dtBase.GetParameterValue(dbCommandQuery, "RESULT"));
                    returnMessage = dtBase.GetParameterValue(dbCommandQuery, "RESULT_MESSAGE").ToString();
                    if (result == 0)
                    {
                        isSuccess = true;
                    }
                }
            }
            catch (Exception exception)
            {
                returnMessage = exception.ToString();
            }
            return isSuccess;
        }
    }
}