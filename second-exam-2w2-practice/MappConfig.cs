using AutoMapper;
using second_exam_2w2_practice.DTOs;
using second_exam_2w2_practice.Model;

namespace second_exam_2w2_practice
{
    public class MappConfig:Profile
    {
        public MappConfig()
        {
            CreateMap<Obra, ObrasGetDTOResponse>()
            .ForMember(response => response.CantidadDeAlbañiles, opt => opt.MapFrom(src => src.AlbanilesXObras.Count())
            )
            .ForMember(response => response.TiposObraDTO, opt => opt.MapFrom( src => new TiposObraDTO
            {
                Id=src.Id,
                Nombre=src.Nombre,
            }));
            CreateMap<AlbanilXObraPostDTORequest, AlbanilesXObra>();
            CreateMap<AlbanilesXObra, AlbanilXObraPostDTOResponse>();
            CreateMap<AlbanilPostDTORequest, Albanile>();
            CreateMap<Albanile,AlbanilPostDTOResponse>();
        }

    }
}
