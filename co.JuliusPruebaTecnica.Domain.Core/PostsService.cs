
using co.JuliusPruebaTecnica.Domain.Core.Interfaces.Repositories;
using co.JuliusPruebaTecnica.Domain.Core.Interfaces.Services;
using co.JuliusPruebaTecnica.Domain.Entities;

namespace co.JuliusPruebaTecnica.Domain.Core
{
    public class PostsService : BaseService<PostNoticias>, IPostsService
    {
        private readonly IPostsRepository postsRepository;

        public PostsService(IPostsRepository postsRepository) : base(postsRepository)
        {
            this.postsRepository = postsRepository;
        }
    }
}
