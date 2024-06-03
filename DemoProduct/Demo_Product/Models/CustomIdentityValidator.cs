using Microsoft.AspNetCore.Identity;

namespace Demo_Product.Models
{
    public class CustomIdentityValidator : IdentityErrorDescriber
    {
        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError()
            {
                Code = "PasswordTooShort",
                Description = "Parola en az 6 karakter içermelidir"
            };
        }

        public override IdentityError PasswordRequiresLower()
        {
        
            return new IdentityError()
            {
                Code = "PasswordRequiresLower",
                Description = "Parola 1 küçük harf içermelidir"
            };
        }

        public override IdentityError PasswordRequiresUpper()
        {
        

            return new IdentityError()
            {
                Code = "PasswordRequiresUpper",
                Description = "Parola 1 Büyük harf içermelidir"
            };
        }
        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresNonAlphanumeric",
                Description = "Parola 1 özel harf içermelidir"
            };
        }

    }
    
}
