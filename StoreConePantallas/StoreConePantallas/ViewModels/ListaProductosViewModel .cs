using StoreConePantallas.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace StoreConePantallas.ViewModels
{
    public class ListaProductosViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<Models.Producto> Productos { get; set; }

        public ListaProductosViewModel()
        {
            // Aquí cargarías tu lista de productos desde algún origen de datos
            Productos = ObtenerProductos();
        }

        ObservableCollection<Producto> ObtenerProductos()
        {
            // Aquí obtendrías tus productos de algún servicio o base de datos
            // Por ejemplo, podrías crear algunos productos de muestra aquí
            return new ObservableCollection<Producto>
        {
            new Producto { Codigo = "001", Nombre = "Producto 1", Seccion = "A", Proveedor = "Proveedor 1", Cantidad = 10, Descripcion = "Descripción del producto 1", Precio = 20 },
            new Producto { Codigo = "002", Nombre = "Producto 2", Seccion = "B", Proveedor = "Proveedor 2", Cantidad = 20, Descripcion = "Descripción del producto 2", Precio = 30 },
            // Agrega más productos según sea necesario
        };
        }
    }
}
