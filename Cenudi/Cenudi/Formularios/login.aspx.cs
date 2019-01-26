using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using Cenudi.Common;
using Cenudi.CAD;

namespace Cenudi.Formularios
{
    public partial class login : System.Web.UI.Page
    {
        //Metodos

        /// <summary>
        /// Metodo que se encarga de realizar el proceso de login
        /// </summary>
        private void Login(UsuarioFiltro usuFiltro) {

            var operaciones = new OperacionesBBDD();

            if (operaciones.Login(usuFiltro))
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "displayalertmessage", "alert('Al pelo hermano');", true);
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "displayalertmessage", "alert('Datos de usuario erroneos')", true);
            }
        }


        ////Eventos

        /// <summary>
        /// Evento cuando pulsamos sobre el botón de login.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button1_Click(object sender, EventArgs e)
        {
            UsuarioFiltro usuFiltro = new UsuarioFiltro();
            if ((txtUsuario.Text != string.Empty) && (txtPassword.Text != string.Empty))
            {
                usuFiltro.nombre = txtUsuario.Text;
                usuFiltro.password = txtPassword.Text;
                Login(usuFiltro);
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "displayalertmessage", "alert('Debe rellenar ambos campos')", true);
            }
        }

    }
}