using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using Cenudi.Common;

namespace Cenudi.CAD
{
    public class OperacionesBBDD
    {

        /// <summary>
        /// Metodo para validar el login de los usuarios
        /// </summary>
        public bool Login(UsuarioFiltro usuFiltro) {
            bool ret = false;

            MySqlConnection mConnect = new MySqlConnection("server=127.0.0.1; database=cenudi; Uid=root; pwd='';");
            MySqlCommand codigo = new MySqlCommand();

            try
            {
                mConnect.Open();
            }
            catch
            {
                Console.WriteLine("Error en la conexion a BBDD");
            }

            codigo.Connection = mConnect;
            codigo.CommandText = $"SELECT COUNT(*) FROM EMPLEADOS WHERE NOMBRE = '{usuFiltro.nombre.ToUpper()}' AND PASSWORD = '{usuFiltro.password}'";

            MySqlCommand mCommand = new MySqlCommand(codigo.CommandText, mConnect);
            var resultado = mCommand.ExecuteScalar();

            if ((resultado != null) && (Int32.Parse(resultado.ToString()) > 0))
            {
                ret = true;
            }
            else
            {
                ret = false;
            }

            mConnect.Close();

            return ret;
        }
    }
}