using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceBackend.Logic.InterfaceLogic
{
    interface IGetLogic <T>
    {
        List<T> GetAll();

    }
}
