

using co.JuliusPruebaTecnica.Aplicacion.Interfaces;
using co.JuliusPruebaTecnica.Aplicacion.Services;
using co.JuliusPruebaTecnica.Domain.Core.Interfaces.Services;
using co.JuliusPruebaTecnica.Domain.Entities;

namespace co.JuliusPruebaTecnica.Aplicacion.Services
{
    public class PostsAppService : BaseAppService<PostNoticias>, IPostsAppService
    {
        private readonly IPostsService postsService;

        public PostsAppService(IPostsService PostsService) : base(PostsService)
        {
            this.postsService = PostsService;
        }
     }
}
