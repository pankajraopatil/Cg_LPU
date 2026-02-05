using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_DAL
{
    internal interface IRepo<T>
    {
       T SearchByID(int id);
       List<T> SearchByName(string name);
    }
}
