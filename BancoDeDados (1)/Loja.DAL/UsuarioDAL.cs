using System;
using System.Collections.Generic;
using System.Text;
using Loja.DTO;
using System.Data.SqlClient;



namespace Loja.DAL
{
    public class UsuarioDAL
    {
        //retorna lista de objetos metodo carga usuario
     /*   public IList<usuario_DTO> cargaUsuario()
        {
            try
            {
                SqlConnection CON = new SqlConnection();
                CON.ConnectionString = Properties.Settings.Default.CST;//Properties.Settings.Default.CST
                SqlCommand CM = new SqlCommand();
                CM.CommandType = System.Data.CommandType.Text;
                CM.CommandText = "SELECT * FROM tb_usuarios";
                CM.Connection = CON;
                SqlDataReader ER;
                IList<usuario_DTO> listUsuarioDTO = new List<usuario_DTO>();

                CON.Open();
                ER = CM.ExecuteReader();
                if (ER.HasRows)
                {
                    while (ER.Read())
                    {
                        usuario_DTO usu = new usuario_DTO();

                        usu.cod_usuario = Convert.ToInt32(ER["cod_usuario"]);
                        usu.perfil = Convert.ToInt32(ER["perfil"]);
                        usu.cadastro = Convert.ToDateTime(ER["cadastro"]);
                        usu.nome = Convert.ToString(ER["nome"]);
                        usu.email = Convert.ToString(ER["email"]);
                        usu.login = Convert.ToString(ER["login"]);
                        usu.senha = Convert.ToString(ER["senha"]);
                        usu.situacao = Convert.ToString(ER["situacao"]);
                        listUsuarioDTO.Add(usu);
                    }
                }
                return listUsuarioDTO;

            }catch(Exception ex)
            {
                throw ex;
            }
        }*/
    }
}
