using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PC4_Recomendation.Models;

namespace PC4_Recomendation.Service
{
    public class ProductoService
    {
         public List<Producto> getTrendingProductos() {
            List<Producto> result = new List<Producto>
            {
                 new Producto { ProductoId = 3, ProductoNombre = "Pizza Hawaiana" },
                 new Producto { ProductoId = 5,  ProductoNombre = "Pizza Pepperoni" },
                 new Producto { ProductoId = 7,  ProductoNombre = "Pizza Cuatro Quesos" }
            };

            return result;
        }
        public List<Producto> getAllProductos() {
            List<Producto> result = new List<Producto>
            {
              new Producto { ProductoId = 1,  ProductoNombre = "Pizza Margarita" },
              new Producto { ProductoId = 2,  ProductoNombre = "Pizza Vegetariana" },
              new Producto { ProductoId = 3,  ProductoNombre = "Pizza Hawaiana" },
              new Producto { ProductoId = 4,  ProductoNombre = "Pizza Carnívora" },
              new Producto { ProductoId = 5,  ProductoNombre = "Pizza Pepperoni" },
              new Producto { ProductoId = 6,  ProductoNombre = "Calzone" },
              new Producto { ProductoId = 7,  ProductoNombre = "Pizza Cuatro Quesos" },
              new Producto { ProductoId = 8,  ProductoNombre = "Pizza Bianca" },
              new Producto { ProductoId = 9,  ProductoNombre = "Pizza Siciliana" },
              new Producto { ProductoId = 10, ProductoNombre = "Pizza a la piedra" }
            };

            return result;
        }
    }
}