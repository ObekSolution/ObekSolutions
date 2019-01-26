using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace Cenudi.Formularios
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            MySqlConnection Conectar = new MySqlConnection("server=databases.000webhost.com; database=id8167586_obek;Uid=id8167586_obek;pwd=1488.1488; ");
            Conectar.Open();

            MySqlCommand codigo = new MySqlCommand();
            MySqlConnection conectarse = new MySqlConnection();
            codigo.Connection = Conectar;
            codigo.CommandText = ("Select * From Usuarios Where Nombre ='"as"' ");
        }
    }
}