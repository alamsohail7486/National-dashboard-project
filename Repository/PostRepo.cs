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
    public class PostRepo : IPost
    {
        private readonly IDbConnection db;
        public PostRepo(IDbConnection db)
        {
            this.db = db;
        }

        public Post InsertPost(Post pst)
        {
            try
            {
                db.Open();
                DynamicParameters param = new DynamicParameters();

                param.Add("@Title", pst.Title);
                param.Add("@Slug", pst.Slug);
                param.Add("@Description", pst.Description);
                param.Add("@Image", pst.Image);
                param.Add("@isActive", pst.IsActive);
                param.Add("@entryDate", DateTime.Now);
                param.Add("#metaDescp", pst.MetaDescp);
                param.Add("#metaKey", pst.MetaKey);
                //param.Add("@publish", pst.publish);

                var insert = SqlMapper.Query<Post>(db, "InsertPost", param, commandType: CommandType.StoredProcedure).FirstOrDefault();
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

        public IList<Post> getPostList()
        {
            try
            {
                db.Open();
                List<Post> list = SqlMapper.Query<Post>(db, "getPostList", commandType: CommandType.StoredProcedure).ToList();
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
        public Post updatePost(Post pst)
        {
            try
            {
                db.Open();
                DynamicParameters param = new DynamicParameters();

                param.Add("@Id", pst.Id);
                param.Add("@Title", pst.Title);
                param.Add("@Slug", pst.Slug);
                param.Add("@Description", pst.Description);
                param.Add("@Image", pst.Image);
                param.Add("@isActive", pst.IsActive);
                param.Add("@entryDate", DateTime.Now);
                param.Add("#metaDescp", pst.MetaDescp);
                param.Add("#metaKey", pst.MetaKey);
                //param.Add("@publish", pst.publish);

                var update = SqlMapper.Query<Post>(db, "updatePost", param, commandType: CommandType.StoredProcedure).FirstOrDefault();
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
        public Post deletePost(int id)
        {
            try
            {
                db.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@Id", id);

                var delete = SqlMapper.Query<Post>(db, "deletePost", param, commandType: CommandType.StoredProcedure).FirstOrDefault();
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
        public Post getPostById(int id)
        {
            try
            {
                db.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@Id", id);

                var postId = SqlMapper.Query<Post>(db, "getPostById", param, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return postId;
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
