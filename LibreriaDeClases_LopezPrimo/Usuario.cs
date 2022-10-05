using System;
using System.Collections.Generic;

namespace LibreriaDeClases_LopezPrimo
{
    public class Usuario
    {
        public string idUsuario;
        public string contraseniaUsuario;


        
        public Usuario(string idUsuario, string contraseniaUsuario)
        {
            this.idUsuario=idUsuario;
            this.contraseniaUsuario = contraseniaUsuario;
        }

        public Usuario()
        {
            this.idUsuario = "";
            this.contraseniaUsuario = "";
        }
        /// <summary>
        /// establesco con que parametro se debe comparar los usuarios
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="username"></param>
        /// <returns>devuelve una comparacion</returns>
        public static bool operator == (Usuario usuario,string username )
        {
            return (usuario.idUsuario == username);
        }
        /// <summary>
        /// establesco con que parametro se debe comparar los usuarios
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="username"></param>
        /// <returns>devuelve una comparacion</returns>
        public static bool operator !=(Usuario usuario, string username)
        {
            return !(usuario.idUsuario == username);
        }
        public override bool Equals(object obj)
        {
            bool retorno = false;
            if(obj is Usuario)
            {
                retorno = this == ((Usuario)obj);
            }
            return retorno;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
