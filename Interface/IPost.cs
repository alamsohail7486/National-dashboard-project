using DashboardProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashboardProject.Interface
{
   public  interface IPost
    {
        Post InsertPost(Post pst);
        Post updatePost(Post pst);
        Post deletePost(int id);
        IList<Post> getPostList();
        Post getPostById(int id);
      


    }
}
