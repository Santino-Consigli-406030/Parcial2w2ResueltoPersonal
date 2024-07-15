using FluentValidation;
using second_exam_2w2_practice.DTOs;

namespace second_exam_2w2_practice.Validators
{
    public class AlbanilPostDTORequestValidator:AbstractValidator<AlbanilPostDTORequest>
    { 
        public AlbanilPostDTORequestValidator()
        {
            RuleFor(x => x.Nombre).NotEmpty().WithMessage("El nombre del albanil es requerido");
            RuleFor(x => x.Apellido).NotEmpty().WithMessage("El apellido del albanil es requerido");
            RuleFor(x => x.Dni).NotEmpty().WithMessage("El dni del albanil es requerido");
        }
    }
}
