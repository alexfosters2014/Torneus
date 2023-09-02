
using System.IdentityModel.Tokens.Jwt;

namespace WebApiTorneus.Services
{
    public static class DecodificadorJWT
    {

        public static string ObenterClaimEmail(string tokenString)
        {
            string email = "";

            // Configura la validación del token JWT (depende de tus requisitos).
            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.ReadJwtToken(tokenString);

            // Accede a los claims del token.
            var claims = token.Claims;

            // Puedes acceder a claims específicos por nombre.
            var userId = claims.FirstOrDefault(c => c.Type == "sub")?.Value; // Cambia "sub" al nombre del claim que necesitas.

            return email;
        }
       

    }



}
