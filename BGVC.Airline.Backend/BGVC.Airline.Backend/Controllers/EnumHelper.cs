using BGVC.Airline.Backend.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BGVC.Airline.Backend.Controllers
{
    public static class EnumHelper
    {
        public static List<ItemIdName> GetIdName<T>() where T : Enum
        {
            var typeList = new List<ItemIdName>();
            foreach (T value in Enum.GetValues(typeof(T)))
            {
                int id = (int)(object)value;
                string name = Enum.GetName(typeof(T), id);
                var enumItem = new ItemIdName
                {
                    Id = id,
                    Name = name
                };

                typeList.Add(enumItem);
            }

            return typeList;
        }

        public static Dictionary<int, string> EnumNamedValues<T>() where T : System.Enum
        {
            var result = new Dictionary<int, string>();
            var values = Enum.GetValues(typeof(T));

            foreach (int item in values)
                result.Add(item, Enum.GetName(typeof(T), item));
            return result;
        }

    }
}
