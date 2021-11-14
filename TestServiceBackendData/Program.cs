using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestServiceBackendData
{
    class Program
    {
        static void Main(string[] args)
        {
            string returnData = RequestToBackendGetAllProductos();
            //string returnData = RequestToBackendData();
            Console.WriteLine("Show data...");
            Console.WriteLine(returnData);
            Console.ReadKey();
        }

        static string RequestToBackendData(int clientID) 
        {
            BackendDataService.ServiceClient client = new BackendDataService.ServiceClient();
            return client.GetPointsClient(clientID);        
        }

        static string RequestToBackendGetAllProductos()
        {           
            BackendDataService.ServiceClient client = new BackendDataService.ServiceClient();          
            return client.GetAllString();
        }
    }
}
