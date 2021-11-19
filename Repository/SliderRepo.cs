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
    public class SliderRepo : ISlider
    {
        private readonly IDbConnection db;
        public SliderRepo(IDbConnection db)
        {
            this.db = db;
        }
        public SliderModel insertSlider(SliderModel pm)
        {
            try
            {
                db.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@Title", pm.Title);
                param.Add("@Image", pm.Image);
                param.Add("@isActive", pm.IsActive);

                var insert = SqlMapper.Query<SliderModel>(db, "insertSlider", param, commandType: CommandType.StoredProcedure).FirstOrDefault();
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
        public IList<SliderModel> GetSliderList()
        {
            try
            {
                db.Open();

                List<SliderModel> list = SqlMapper.Query<SliderModel>(db, "GetSliderList", commandType: CommandType.StoredProcedure).ToList();
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
        public SliderModel updateSlider(SliderModel pm)
        {
            try
            {
                db.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@Id", pm.Id);
                param.Add("@Title", pm.Title);
                param.Add("@Image", pm.Image);
                param.Add("@isActive", pm.IsActive);

                var update = SqlMapper.Query<SliderModel>(db, "updateSlider", param, commandType: CommandType.StoredProcedure).FirstOrDefault();
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
        public SliderModel deleteSlider(int Id)
        {
            try
            {
                db.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@Id", Id);

                var delete = SqlMapper.Query<SliderModel>(db, "deleteSlider", param, commandType: CommandType.StoredProcedure).FirstOrDefault();
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

        public SliderModel GetSliderById(int Id)
        {
            try
            {
                db.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@Id", Id);

                var get = SqlMapper.Query<SliderModel>(db, "GetSliderById", param, commandType: CommandType.StoredProcedure).FirstOrDefault();
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

      
        

      
    }
}
