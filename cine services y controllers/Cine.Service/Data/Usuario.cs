using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Cine.Service.Dominio;
using System.Data.SqlClient;
using System.Data;

namespace Cine.Service.Data
{
    public class Usuario
    {
        string cadenaConexion = "Server=(local);Database=BDCinepolis1; Integrated Security=true;";

        public List<Colaborador> validar_user(int idcol, string pass)
        {
            List<Colaborador> listado = new List<Colaborador>();

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("IniciarSeccion", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idCola", idcol);
                comando.Parameters.AddWithValue("@Pass", pass);
                SqlDataReader dr = comando.ExecuteReader();
                if (dr != null && dr.HasRows)
                {
                    Colaborador cola;
                    while (dr.Read())
                    {
                        cola = new Colaborador();
                        cola.idColaborador = int.Parse(dr["idColaborado"].ToString());
                        cola.dni = dr["dni"].ToString();
                        cola.nombres = dr["nombres"].ToString();
                        cola.apellidoPaterno = dr["apellidoPaterno"].ToString();
                        cola.apellidoMaterno = dr["apellidoMaterno"].ToString();
                        cola.password = dr["password"].ToString();
                        cola.sexo = dr["sexo"].ToString();
                        cola.direccion = dr["direccion"].ToString();
                        //cola.fechaNacimiento = dr["fechaNacimiento"];
                        //cola.telefono = dr["telefono"].ToString();
                        listado.Add(cola);
                    }
                }

            }
            return listado;

        }
    }       
    
  }
