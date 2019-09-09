namespace NihongoService.Bll.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Models.Models;
    using Repository.Repository;

    public interface IVocabularyService
    {
        Task<IEnumerable<Vocabulary>> GetAllVocabularies();

        Task<Vocabulary> GetVocabularyById(int id);
    }

    public class VocabularyService : IVocabularyService
    {
        private readonly IVocabularyRepository _vocabularyRepository;

        // TODO: use dependency injection
        public VocabularyService()
        {
            _vocabularyRepository = new VocabularyRepository();
        }

        /*
        public VocabularyService(IVocabularyRepository vocabularyRepository)
        {
            _vocabularyRepository = vocabularyRepository;
        }
        */

        public async Task<IEnumerable<Vocabulary>> GetAllVocabularies()
        {
            return await _vocabularyRepository.GetAllVocabularies().ConfigureAwait(false);
        }

        public async Task<Vocabulary> GetVocabularyById(int id)
        {
            return await _vocabularyRepository.GetVocabularyById(id).ConfigureAwait(false);
        }
    }
}
