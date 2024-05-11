using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHSUNGTUYEN
{
    internal class LoginBus
    {
        public static DataTable CheckLogin(string loaitk, string email, string password)
        {
            string sql_check = "CheckLogin";

            // paremeters
            List<CustomParameter> parameters = new List<CustomParameter>();
            parameters.Add(new CustomParameter()
            {
                key = "@LoaiTK",
                value = loaitk.ToString()
            });
            parameters.Add(new CustomParameter()
            {
                key = "@Email",
                value = email.ToString()
            });
            parameters.Add(new CustomParameter()
            {
                key = "@Password",
                value = password.ToString()
            });

            // Truyền 2 tham số là câu lệnh sql và danh sách các tham số
            var res = new Database().SelectData(sql_check, parameters);
            return res;
        }
        public static string GetUserID(string loaitk, string email, string password)
        {
            string sql_getid = "GetUserID";

            // paremeters
            List<CustomParameter> parameters = new List<CustomParameter>();
            parameters.Add(new CustomParameter()
            {
                key = "@LoaiTK",
                value = loaitk.ToString()
            });
            parameters.Add(new CustomParameter()
            {
                key = "@Email",
                value = email.ToString()
            });
            parameters.Add(new CustomParameter()
            {
                key = "@Password",
                value = password.ToString()
            });

            // Truyền 2 tham số là câu lệnh sql và danh sách các tham số
            var row = new Database().Select(sql_getid, parameters);
            string user_id = row["UserID"].ToString();

            return user_id;
        }

    }
}
