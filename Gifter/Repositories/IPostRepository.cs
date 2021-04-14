using Gifter.Models;
using System.Collections.Generic;

namespace Gifter.Repositories
{
    public interface IPostRepository
    {
        void Add(Post post);
        void Delete(int id);
        List<Post> GetAll();
        List<Post> GetAllWithComments();
        Post GetPostByIdWithComments(int id);
        Post GetById(int id);
        void Update(Post post);
        List<Post> Search(string criterion, bool sortDescending);
    }
}