
using DTOs_Compartidos.DTOs;
using System.IdentityModel.Tokens.Jwt;

namespace WebApiTorneus.Services
{
    public static class DecodificadorJWT
    {

        public static LoginGoogleDTO ObtenerDatosUsuarioGoogle(string tokenString)
        {
            try
            {
                LoginGoogleDTO usuarioGogole = new();

                var tokenHandler = new JwtSecurityTokenHandler();
                var token = tokenHandler.ReadJwtToken(tokenString);

                // Accede a los claims del token.
                var claims = token.Claims;

                usuarioGogole.Pass = claims.FirstOrDefault(c => c.Type == "sub")?.Value;
                usuarioGogole.Email = claims.FirstOrDefault(c => c.Type == "email")?.Value;
                usuarioGogole.Nombre = claims.FirstOrDefault(c => c.Type == "name")?.Value;

                return usuarioGogole;
            }
            catch (Exception ex)
            {
                throw new Exception("El usuario de google no existe");
            }
           
        }
       

    }



}
