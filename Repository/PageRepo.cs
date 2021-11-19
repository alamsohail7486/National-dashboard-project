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
    public class PageRepo : IPage
    {
        private readonly IDbConnection db;
        public PageRepo(IDbConnection db)
        {
            this.db = db;
        }
        public PageModel InsertPage(PageModel pm)
        {
            try
            {
                db.Open();
                DynamicParameters param = new DynamicParameters();
               // param.Add("@Id", pm.Id);
                param.Add("@Title", pm.Title);
                param.Add("@Slug", pm.Slug);
                param.Add("@Description", pm.Description);
                param.Add("@Image", pm. Image);
                param.Add("@metaDesc", pm.metaDesc);
                param.Add("@metaKeys", pm.metaKeys);
                param.Add("@isActive", pm.IsActive);

                var insert = SqlMapper.Query<PageModel>(db, "InsertPage", param, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return insert;
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

        public IList<PageModel> PageList()
        {
            try
            {
                db.Open();

                List<PageModel> list = SqlMapper.Query<PageModel>(db, "PageList", commandType: CommandType.StoredProcedure).ToList();
                return list;
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

        public PageModel UpdatePage(PageModel pm)
        {
            try
            {
                db.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@Id", pm.Id);
                param.Add("@Title", pm.Title);
                param.Add("@Slug", pm.Slug);
                param.Add("@Description", pm.Description);
                param.Add("@Image", pm.Image);
                param.Add("@metaDesc", pm.metaDesc);
                param.Add("@metaKeys", pm.metaKeys);
                param.Add("@isActive", pm.IsActive);

                var update = SqlMapper.Query<PageModel>(db, "UpdatePage", param, commandType: CommandType.StoredProcedure).FirstOrDefault();
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

        public PageModel GetPageById(int Id)
        {
            try
            {
                db.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@Id", Id);

                var get = SqlMapper.Query<PageModel>(db, "GetPageById", param, commandType: CommandType.StoredProcedure).FirstOrDefault();
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

        public PageModel DeletePage(int Id)
        {
            try
            {
                db.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@Id", Id);

                var delete = SqlMapper.Query<PageModel>(db, "DeletePage", param, commandType: CommandType.StoredProcedure).FirstOrDefault();
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
