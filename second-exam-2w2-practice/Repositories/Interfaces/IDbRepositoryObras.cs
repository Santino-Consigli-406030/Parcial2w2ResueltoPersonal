using second_exam_2w2_practice.DTOs;
using second_exam_2w2_practice.Model;

namespace second_exam_2w2_practice.Repositories.Interfaces
{
    public interface IDbRepositoryObras
    {
        Task<List<ObrasGetDTOResponse>> GetObrasAsync();
        Task<AlbanilXObraPostDTOResponse> PostAlbanilXObraAsync(AlbanilXObraPostDTORequest albanilXObraPostDTORequest);
        Task<List<Albanile>> GetAlbanilesNotInObraAsync(Guid id);
        Task<AlbanilPostDTOResponse> PostAlbanilAsync(AlbanilPostDTORequest albanilPostDTORequest);
    }
}
