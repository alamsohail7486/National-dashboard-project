using Dapper;
using DashboardProject.Interface;
using DashboardProject.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace DashboardProject.Repository
{
    public class UserRepo : IUser
    {
        private readonly IDbConnection db;
        public UserRepo(IDbConnection db)
        {
            this.db = db;
        }
        public UserModel Login(UserModel sa)
        {
            try
            {
                db.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@username", sa.userName);
                param.Add("@password", sa.Password);

                var update = SqlMapper.Query<UserModel>(db, "Login", param, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return update;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Close();
            }
        }
    }
}
