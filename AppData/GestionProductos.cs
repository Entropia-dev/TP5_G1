using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TP5_GRUPO1.AppData
{
    public class GestionProductos
    {
    
    public GestionProductos()
        {

        }

    private DataTable obtenertabla (string nombre , string sql) 
    {
        DataSet ds = new DataSet();
        AccesoDatos datos = new AccesoDatos();
        SqlDataAdapter adp = datos.ObtenerAdaptador(sql);
        adp.Fill(ds, nombre);
        return ds.Tables[nombre];
    }

        public DataTable obtenerTodoslosproductos()
        {
            return obtenertabla("Productos", "SELECT IdProducto, NombreProducto, CantidadPorUnidad, PrecioUnidad from Productos");
        }

        private void ArmarParametrosProductosEliminar(ref SqlCommand comando , Productos producto)
        {
            SqlParameter sqlparametros = new SqlParameter();
            sqlparametros = comando.Parameters.Add("IdProducto", SqlDbType.Int);
            sqlparametros.Value = producto.idProducto;
        }

        private void ArmarParametrosProductos(ref SqlCommand comando , Productos producto)
        {
            SqlParameter sqlparametros = new SqlParameter();
            sqlparametros = comando.Parameters.Add("@IdProducto", SqlDbType.Int);
            sqlparametros.Value = producto.idProducto;
            sqlparametros = comando.Parameters.Add("@NompreProducto", SqlDbType.VarChar);
            sqlparametros.Value = producto.nombreProducto;
            sqlparametros = comando.Parameters.Add("@CantidadPorUnidad", SqlDbType.VarChar);
            sqlparametros.Value = producto.cantUnidades;
            sqlparametros = comando.Parameters.Add("@PrecioUnidad", SqlDbType.Money);
        }

        public bool ActualizarProducto(Productos prod)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosProductos(ref comando, prod);
            AccesoDatos ad = new AccesoDatos();
            int filasinsertadas = ad.EjecutarprocedimientoAlmacenado(comando, "spactualizarproducto");
            if(filasinsertadas == 1) { return true; } else { return false; }
        }

        public bool EliminarProducto(Productos prod)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosProductosEliminar(ref comando, prod);
            AccesoDatos ad = new AccesoDatos();
            int filas_insertadas = ad.EjecutarprocedimientoAlmacenado(comando, "spEliminarProducto");
            if(filas_insertadas == 1) { return true; } else { return false; }
        }
    }
}