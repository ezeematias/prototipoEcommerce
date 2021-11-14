using ServiceBackend.Entities;
using ServiceBackend.Entities.ClassDTO;
using ServiceBackend.Logic.InterfaceLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceBackend.Logic.ClassLogic
{
    public class ProductoLogic : BaseLogic, IGetLogic<Producto>, IABMLogic<Producto>
    {
        public void Add(Producto addItem)
        {
            try
            {
                context.Productos.Add(addItem);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(int id)
        {
            try
            {
                var localidadDelete = context.Productos.Find(id);
                if (localidadDelete != null)
                {
                    localidadDelete.Available = 0;
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("No existe el producto a eliminar.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Producto> GetAll()
        {
            try
            {
                return context.Productos.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Producto GetById(int value)
        {
            try
            {
                return context.Productos.Find(value);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string GettAllString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("XXX LISTADO DE PRODUCTO XXX");
            foreach (var item in context.Productos.ToList())
            {
                sb.AppendLine(item.ID_Producto.ToString());
                sb.AppendLine(item.Nombre);
                sb.AppendLine(item.Marca);
                sb.AppendLine(item.Descripción);
                sb.AppendLine(item.Precio.ToString());
                sb.AppendLine(item.Stock.ToString());
                sb.AppendLine("-------------------------");
            }
            return sb.ToString();
        }

        public void Update(Producto updateItem)
        {
            try
            {
                var bufferLocalidades = context.Productos.Find(updateItem.ID_Producto);
                if (bufferLocalidades != null)
                {
                    bufferLocalidades.Nombre = updateItem.Nombre;
                    bufferLocalidades.Marca = updateItem.Marca;
                    bufferLocalidades.Precio = updateItem.Precio;
                    bufferLocalidades.Descripción = updateItem.Descripción;
                    bufferLocalidades.Stock = updateItem.Stock;
                    bufferLocalidades.Available = updateItem.Available;
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("No existe el producto a modificar.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
