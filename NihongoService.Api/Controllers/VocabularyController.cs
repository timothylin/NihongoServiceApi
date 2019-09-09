namespace NihongoServiceApi.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Web.Http;
    using NihongoService.Bll.Services;
    using NihongoService.Models.Models;

    public class VocabularyController : ApiController
    {
        private readonly IVocabularyService _vocabularyService;

        // TODO: use dependency injection
        public VocabularyController()
        {
            _vocabularyService = new VocabularyService();
        }

        /*
        public VocabularyController(IVocabularyService vocabularyService)
        {
            _vocabularyService = vocabularyService;
        }
        */

        public async Task<IEnumerable<Vocabulary>> Get()
        {
            try
            {
                return await _vocabularyService.GetAllVocabularies().ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                // TODO: log and then mask exception from user
                // throwing again so that the response code will be 500
                throw;
            }
        }
    }
}
