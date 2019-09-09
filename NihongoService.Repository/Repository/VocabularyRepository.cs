namespace NihongoService.Repository.Repository
{
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Threading.Tasks;
    using Config;
    using Dapper;
    using Models.Models;

    public interface IVocabularyRepository
    {
        Task<IEnumerable<Vocabulary>> GetAllVocabularies();

        Task<Vocabulary> GetVocabularyById(int id);
    }

    public class VocabularyRepository : IVocabularyRepository
    {
        public async Task<IEnumerable<Vocabulary>> GetAllVocabularies()
        {
            using (var cn = new SqlConnection(Settings.ConnectionString))
            {
                return await cn
                    .QueryAsync<Vocabulary>("[dbo].[usp_GetAllVocabularies]", commandType: CommandType.StoredProcedure)
                    .ConfigureAwait(false);
            }
        }

        public async Task<Vocabulary> GetVocabularyById(int id)
        {
            using (var cn = new SqlConnection(Settings.ConnectionString))
            {
                return (await cn
                    .QueryAsync<Vocabulary>("[dbo].[usp_GetAllVocabularies]", new { id }, commandType: CommandType.StoredProcedure)
                    .ConfigureAwait(false)).SingleOrDefault();
            }
        }
    }
}
