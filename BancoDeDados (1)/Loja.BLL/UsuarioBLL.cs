using System;
using System.Collections.Generic;
using System.Text;
using Loja.DAL2;
using Loja.DTO;

namespace Loja.BLL
{
    public class UsuarioBLL
    {
        public IList<usuario_DTO> cargaUsuario()
        {
            try
            {
                return new UsuarioDAL2().cargaUsuario();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public int insereUsuario(usuario_DTO USU)
        {
            try
            {
                return new UsuarioDAL2().insereUsuario(USU);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int editaUsuario (usuario_DTO USU)
        {
            try
            {
                return new UsuarioDAL2().editaUsuario(USU);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int deletaUsuario (usuario_DTO USU)
        {
            try
            {
                return new UsuarioDAL2().deletaUsuario(USU);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
