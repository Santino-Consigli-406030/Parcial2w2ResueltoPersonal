namespace second_exam_2w2_practice.DTOs
{
    public class AlbanilXObraPostDTOResponse
    {
        public Guid Id { get; set; }
        public Guid IdAlbanil { get; set; }
        public Guid IdObra { get; set; }
        public string TareaArealizar { get; set; } = null!;
        public DateTime? FechaAlta { get; set; }
    }
}
