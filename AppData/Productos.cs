using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP5_GRUPO1.AppData
{
    public class Productos
    {
        private int id_producto;
        private string nombre_producto;
        private string cant_Unidad;
        private decimal precio_x_unidad;

        public Productos()
        {

        }


        public Productos(int id_producto , string nombre_producto , string cant_Unidad, decimal precio_x_unidad)
        {
            this.id_producto = id_producto;
            this.nombre_producto = nombre_producto;
            this.cant_Unidad = cant_Unidad;
            this.precio_x_unidad = precio_x_unidad;
        }

        public int idProducto
        {
            get { return id_producto; }
            set { id_producto = value; }
        }

        public string nombreProducto {
            get { return nombre_producto; }
            set { nombre_producto = value; }
        }

        public string cantUnidades
        {
            get { return cant_Unidad; }
            set { cant_Unidad = value; }
        }

        public decimal precioxunidad
        {
            get { return precio_x_unidad; }
            set { precio_x_unidad = value; }
        }

    }

}