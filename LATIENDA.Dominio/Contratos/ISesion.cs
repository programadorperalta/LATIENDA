using LATIENDA.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LATIENDA.Dominio
{
    public interface ISesion
    {
        void Conectar();
        void Desconectar();
        Usuario GetUsuario();
        void EnviarUsuario(Usuario usuario);

    }
}
