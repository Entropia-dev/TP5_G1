using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TP5_GRUPO1.AppData;

namespace TP5_GRUPO1
{
    public partial class Ejercicio1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack == false)
            {
                cargar_gridView();

            }
        }
        public void cargar_gridView()
        {
            GestionProductos gprods = new GestionProductos();
            grdProductos.DataSource = gprods.obtenerTodoslosproductos();
            grdProductos.DataBind();
        }
    }
}