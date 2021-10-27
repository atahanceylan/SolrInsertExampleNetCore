using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SolrInsertWebAPIExample.Models;
using SolrInsertWebAPIExample.Services;
using SolrNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolrInsertWebAPIExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PostController : ControllerBase
    {
        private readonly ILogger<PostController> _logger;
        // define an instance of SolrIndexService which should be injected from the constructor
        ISolrIndexService<SolrPostModel> solrIndexService;

        public PostController(ILogger<PostController> logger, ISolrIndexService<SolrPostModel> solrIndexService)
        {
            _logger = logger;
            this.solrIndexService = solrIndexService;
        }

        [HttpPost]
        public IActionResult AddSolr(Post newPost)
        {
            SolrPostModel solrPostModel = new SolrPostModel(newPost);
            solrIndexService.AddUpdate(solrPostModel);
            return Ok("Added Successfully");
        }
       
    }
}
