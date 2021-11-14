using ServiceBackend.Entities;
using ServiceBackend.Logic.ClassLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
    ProductoLogic productoLogic = new ProductoLogic();
    public string GetData(int value)
    {
        return string.Format("You entered: {0}", value);
    }

    public string GetPointsClient(int clientID)
    {
        return "1000";
    }

    public CompositeType GetDataUsingDataContract(CompositeType composite)
    {
        if (composite == null)
        {
            throw new ArgumentNullException("composite");
        }
        if (composite.BoolValue)
        {
            composite.StringValue += "Suffix";
        }
        return composite;
    }

    public List<Producto> GetAll()
    {
        return productoLogic.GetAll().Where(p => p.Available == 1).ToList();
    }

    public Producto GetById (int value)
    {
        return productoLogic.GetById(value);        
    }

    public string GetAllString()
    {
        return productoLogic.GettAllString();
    }

    public string Add(Producto producto)
    {
        try
        {
            productoLogic.Add(producto);
            return "AGREGADO CORRECTAMENTE";
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public string Delete(int value)
    {
        try
        {
            productoLogic.Delete(value);
            return "ELIMINADO CORRECTAMENTE";

        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public string Update(Producto producto)
    {
        try
        {
            producto.Available = 1;
            productoLogic.Update(producto);
            return "MODIFUCADO CORRECTAMENTE";
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}
