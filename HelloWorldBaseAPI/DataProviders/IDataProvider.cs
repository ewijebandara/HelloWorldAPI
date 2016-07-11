using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldBaseAPI.DataProviders
{
    public interface IDataProvider
    {
        string GetData();
    }
}
