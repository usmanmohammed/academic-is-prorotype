using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Desktop.Helpers
{
    public static class Extensions
    {
        public static IEnumerable<T> Flatten<T, R>(this IEnumerable<T> source, Func<T, R> recursion) where R : IEnumerable<T>
        {
            var final = source.ToList();
            var items = source.Select(recursion);
            if (items != null)
            {
                foreach (var item in items)
                {
                    final.AddRange(item.Flatten(recursion));
                }
            }
            return final;
        }
    }
}
