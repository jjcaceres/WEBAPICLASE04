using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Galaxy.ServicesRESTNet.EF2.Context;
using Galaxy.ServicesRESTNet.EF2.Entities;

namespace Galaxy.ServicesRESTNet.API2.Application
{
    public class PostApplication : IPostApplication
    {
        private GalaxyBlogContext _galaxyBlogContext { get; }
        public PostApplication(GalaxyBlogContext galaxyBlogContext)
        {
            _galaxyBlogContext = galaxyBlogContext;
        }
        public Post DeletePost(int postId)
        {
            Post postDelete = _galaxyBlogContext.Posts.Find(postId);
            _galaxyBlogContext.Posts.Remove(postDelete);
            _galaxyBlogContext.SaveChanges();

            return postDelete;
        }

        public Post GetPost(int postId)
        {
            IQueryable<Post> query = from posts in _galaxyBlogContext.Posts
                                     where posts.PostId == postId
                                     select posts;
            Post post = query.FirstOrDefault();
            return post;

        }

        public Post InsertPost(Post post)
        {
            _galaxyBlogContext.Posts.Add(post);
            _galaxyBlogContext.SaveChanges();
            return post;
        }

        public List<Post> ListPosts()
        {
            return _galaxyBlogContext.Posts.ToList();
        }

        public Post UpdatePost(Post post)
        {
            Post postUpdate = _galaxyBlogContext.Posts.Find(post.PostId);
            postUpdate.Titulo = post.Titulo;
            postUpdate.Contenido = post.Contenido;

            _galaxyBlogContext.Posts.Update(postUpdate);
            _galaxyBlogContext.SaveChanges();

            return post;

        }
    }
}
