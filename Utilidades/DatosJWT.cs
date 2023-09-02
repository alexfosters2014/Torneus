using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades
{
    public static class DatosJWT
    {

        public static string ObtenerNombreUsuarioGoogle(string tokenString)
        {
            try
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var token = tokenHandler.ReadJwtToken(tokenString);

                // Accede a los claims del token.
                var claims = token.Claims;

                string? nombre = claims.FirstOrDefault(c => c.Type == "name")?.Value;

                return nombre;
            }
            catch (Exception ex)
            {
                throw new Exception("El usuario de google no existe");
            }

        }
    }



}
