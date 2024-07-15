using AutoMapper;
using Microsoft.EntityFrameworkCore;
using second_exam_2w2_practice.Context;
using second_exam_2w2_practice.DTOs;
using second_exam_2w2_practice.Model;
using second_exam_2w2_practice.Repositories.Interfaces;
using System.Runtime.InteropServices;

namespace second_exam_2w2_practice.Repositories.Impl
{
    public class DbRepositoryObras : IDbRepositoryObras
    {
        private readonly ObrasContext _obrasContext;
        private readonly IMapper _mapper;
        public DbRepositoryObras(ObrasContext obrasContext, IMapper mapper) {
            _obrasContext = obrasContext;
            _mapper = mapper;
        }

        public async Task<List<Albanile>> GetAlbanilesNotInObraAsync(Guid id)
        {
            var albaniles = await _obrasContext.Albaniles.Where(a => a.Activo==true && !_obrasContext.AlbanilesXObras.Where(aXobras => aXobras.IdObra== id)
            .Select(aXobras => aXobras.IdAlbanil) //se utiliza para formar una lista de objetos y poder verificar condiciones acerca del requerimiento
                                                  //del problema, en este caso se busca todos los albaniles que existen en una obra.
            .Contains(a.Id))
            .ToListAsync();

            return albaniles;
        }

        public async Task<List<ObrasGetDTOResponse>> GetObrasAsync()
        {
            var obras = await _obrasContext.Obras.Include(AlbObr=>AlbObr.AlbanilesXObras).Where(obras => obras.AlbanilesXObras.Count() > 0).ToListAsync();
            var obrasResponse = _mapper.Map<List<ObrasGetDTOResponse>>(obras);
            return obrasResponse;
        }

        public async Task<AlbanilPostDTOResponse> PostAlbanilAsync(AlbanilPostDTORequest albanilPostDTORequest)
        {
            var albanilExist = await _obrasContext.Albaniles.FirstOrDefaultAsync(a => a.Dni == albanilPostDTORequest.Dni);
            if (albanilExist == null)
            {
                var albanilEntity = _mapper.Map<Albanile>(albanilPostDTORequest);
                albanilEntity.Id=Guid.NewGuid();
                albanilEntity.Activo = true;
                _obrasContext.Albaniles.Add(albanilEntity);
                await _obrasContext.SaveChangesAsync();
                var albanilResponse = _mapper.Map<AlbanilPostDTOResponse>(albanilEntity);
                return albanilResponse;
            }
            else
            {
                return null;
            }
        }

        public async Task<AlbanilXObraPostDTOResponse> PostAlbanilXObraAsync(AlbanilXObraPostDTORequest albanilXObraPostDTORequest)
        {
             var albanilXObrasExist = await _obrasContext.AlbanilesXObras.FirstOrDefaultAsync(albanilXobra=>albanilXobra.IdAlbanil==albanilXObraPostDTORequest.IdAlbanil
             && albanilXobra.IdObra==albanilXObraPostDTORequest.IdObra);
            if(albanilXObrasExist == null)
            {
                var albanilXObraEntity = _mapper.Map<AlbanilesXObra>(albanilXObraPostDTORequest);
                 albanilXObraEntity.Id= Guid.NewGuid();
                _obrasContext.AlbanilesXObras.Add(albanilXObraEntity);
                await _obrasContext.SaveChangesAsync();
                return _mapper.Map<AlbanilXObraPostDTOResponse>(albanilXObraEntity);          
            }
            else
            {
                return null;
            }

        }
    }
}
