using Microsoft.Extensions.Logging;
using SolrInsertWebAPIExample.Models;
using SolrNet;
using SolrNet.Commands.Parameters;
using SolrNet.Exceptions;
using System.Linq;
using System.Threading.Tasks;

namespace SolrInsertWebAPIExample.Services
{
    public class SolrIndexService<T, TSolrOperations> : ISolrIndexService<T>
    where TSolrOperations : ISolrOperations<T>
    {
        private readonly TSolrOperations _solr;
        private readonly ILogger<ISolrOperations<T>> _logger;
        public SolrIndexService(ISolrOperations<T> solr, ILogger<ISolrOperations<T>> logger = null)
        {
            _solr = (TSolrOperations)solr;
            _logger = logger;
        }
        public bool AddUpdate(T document)
        {
            try
            {
                // If the id already exists, the record is updated, otherwise added                         
                _solr.Add(document);
                _solr.Commit();
                return true;
            }
            catch (SolrNetException ex)
            {
                //Log exception
                _logger.LogError($"Exception occured {ex.Message} ");
                return false;
            }
        }

        public bool Delete(T document)
        {
            try
            {
                //Can also delete by id                
                _solr.Delete(document);
                _solr.Commit();
                return true;
            }
            catch (SolrNetException ex)
            {
                _logger.LogError($"Exception occured {ex.Message} ");
                return false;
            }
        }
        
    }
}
