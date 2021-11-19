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
    public class CatRepo : ICategory 
    {
        private readonly IDbConnection db;
            public CatRepo (IDbConnection db)
        {
            this.db = db;
        }
        public Category insertCategory(Category cat)
        {
            try
            {
                db.Open();
                DynamicParameters param = new DynamicParameters();
                 //param.Add("@Id", cat.Id);
                param.Add("@Title", cat.Title);
                param.Add("@Slug", cat.Slug);
                param.Add("@isActive", cat.IsActive);
                param.Add("@entryDate", DateTime.Now);

                var insert = SqlMapper.Query<Category>(db, "insertCategory", param, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return (insert);
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

        public IList<Category> GetAllList(string search)
        {
            try
            {
                db.Open();
                DynamicParameters parm = new DynamicParameters();
                parm.Add("@Title", search);
                List<Category> about = SqlMapper.Query<Category>(db, "GetAllList", parm,commandType: CommandType.StoredProcedure).ToList();
                return about;
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

        public Category updateCategory(Category cat)
        {
            try
            {
                db.Open();
                DynamicParameters param = new DynamicParameters();

                param.Add("@Id", cat.Id);
                param.Add("@Title", cat.Title);
                param.Add("@Slug", cat.Slug);
                param.Add("@isActive", cat.IsActive);
                param.Add("@entryDate", DateTime.Now);

                var update = SqlMapper.Query<Category>(db, "updateCategory", param, commandType: CommandType.StoredProcedure).FirstOrDefault();
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

        public Category GetListById(int id)
        {
            try
            {
                db.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@Id", id);
                var get = SqlMapper.Query<Category>(db, "GetListById", param, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return get;
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

        public Category deleteCategory(int id)
        {
            try
            {
                db.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@Id", id);

                var delete = SqlMapper.Query<Category>(db, "deleteCategory", param, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return delete;
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
