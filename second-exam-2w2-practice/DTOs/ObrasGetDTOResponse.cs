using second_exam_2w2_practice.Model;

namespace second_exam_2w2_practice.DTOs
{
    public class ObrasGetDTOResponse
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string DatosVarios { get; set; } = null!;
        public Guid IdTipoObra { get; set; }
        public int CantidadDeAlbañiles { get; set; }
        public TiposObraDTO TiposObraDTO { get; set; }
    }
}
