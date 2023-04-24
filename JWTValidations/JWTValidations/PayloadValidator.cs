using FluentValidation;
using System.IdentityModel.Tokens.Jwt;

namespace JWTValidations
{
    public class PayloadValidator : AbstractValidator<Payload>
    {
        public PayloadValidator()
        {
            RuleFor(payload => payload.Fingerprint).NotNull().NotEmpty();
            RuleFor(tpor => tpor.Fingerprint).Must(
                (string f) =>
                {
                    var hdl = new JwtSecurityTokenHandler();
                    return hdl.CanReadToken(f);
                }).WithMessage("Not a valid JWT.");
        }
        private bool BeAValidJWT(string f)
        {
            var hdl = new JwtSecurityTokenHandler();
            return hdl.CanReadToken(f);        
        }
    }
}
