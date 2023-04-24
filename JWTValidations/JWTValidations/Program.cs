// See https://aka.ms/new-console-template for more information
using FluentValidation.Results;
using JWTValidations;

Payload p = new Payload();
p.Fingerprint = "Not A JWT";
//p.Fingerprint = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxMjM0NTY3ODkwIiwibmFtZSI6IkpvaG4gRG9lIiwiaWF0IjoxNTE2MjM5MDIyfQ.KoX47eKMNMKoSEOqxaE9PrYeO2rwUOlVtqc7jRPSHHE";

PayloadValidator validator = new PayloadValidator();
ValidationResult validationResult = validator.Validate(p);
if( validationResult.IsValid )
{
    Console.WriteLine("Valid JWT");
}
else
{
    Console.WriteLine("Not a valid JWT entered!!");
}
