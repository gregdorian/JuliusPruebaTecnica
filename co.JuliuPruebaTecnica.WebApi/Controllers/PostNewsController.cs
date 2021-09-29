using co.JuliusPruebaTecnica.Aplicacion.Interfaces;
using co.JuliusPruebaTecnica.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace co.JuliuPruebaTecnica.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostNewsController : ControllerBase
    {

        private readonly IPostsAppService postsAppService;

        private readonly ILogger<PostNewsController> _logger;
        //private readonly UserManager<RpUsers> userManager;

        public PostNewsController(IPostsAppService postsAppService,
                                  ILogger<PostNewsController> logger )
        {
            this.postsAppService = postsAppService;
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }
        

        // GET: api/<PostNewsController>
        [HttpGet]
         public IEnumerable<PostNoticias> Get()
        {
            var lstPost = postsAppService.GetAll();

            _logger.LogInformation($"Status Listed: ");

            return lstPost;
        }

        // GET api/<PostNewsController>/5
        [HttpGet("{id}")]
        [Authorize]
        //[Authorize(Roles = "Administrator, RegularUser")]
        public ActionResult<PostNoticias> Get(int id)
        {
            var post = postsAppService.GetById(id);
            if (post == null)
            {
                _logger.LogError("No Data found");
                return NotFound();
            }
            return Ok(post);
        }

        // POST api/<PostNewsController>
        [HttpPost]
        [Authorize]
        public void Post([FromBody] PostNoticias value)
        {
        }

        // PUT api/<PostNewsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] PostNoticias value)
        {
            if (value != null)
            {
                postsAppService.Add(value);
                _logger.LogInformation("Data SAVED!!!");
            }
            else
            {
                _logger.LogError("No Data found");
            }
        }

        // DELETE api/<PostNewsController>/5
        [HttpDelete("{id}")]
        [Authorize]
        public void Delete(int id)
        {
            postsAppService.Delete(id);
            _logger.LogInformation("Data Deleted");
        }
    }
}
