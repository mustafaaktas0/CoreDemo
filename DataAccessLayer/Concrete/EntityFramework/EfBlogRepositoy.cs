using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EfBlogRepositoy : GenericRepository<Blog>, IBlogDal
    {
    }

}

