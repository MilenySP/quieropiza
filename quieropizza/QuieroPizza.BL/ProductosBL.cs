﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuieroPizza.BL
{
    public class ProductosBL
    {
        //lista de objetos
        public List<Producto> ObtenerProductos()
        {
            var producto1 = new Producto();
            producto1.Id = 1;
            producto1.Descripcion = "Pizza 6 Quesos";
            producto1.Precio = 200;

            var producto2 = new Producto();
            producto2.Id = 2;
            producto2.Descripcion = "Pizza 4 Estaciones";
            producto2.Precio = 250;

            var producto3 = new Producto();
            producto3.Id = 3;
            producto3.Descripcion = "Pizza Jamon y Queso";
            producto3.Precio = 180;

            //variable de lista de objetos
            var listaproducto = new List<Producto>();
            listaproducto.Add(producto1);
            listaproducto.Add(producto2);
            listaproducto.Add(producto3);
            return listaproducto;
        }
    }
}
