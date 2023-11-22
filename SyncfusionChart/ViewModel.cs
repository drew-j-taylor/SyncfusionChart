using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncfusionChart
{
    public class ViewModel
    {
        public string Average { get; set; }
        public List<Person> Data { get; set; }
        public ViewModel()
        {
            double ave = 0;
            Data = new List<Person>()
            {
                new Person { Name = "David", Height = 170 },
                new Person { Name = "Michael", Height = 96 },
                new Person { Name = "Steve", Height = 65 },
                new Person { Name = "Joel", Height = 182 },
                new Person { Name = "Bob", Height = 134 }
            };
            foreach (var item in Data)
            {
                ave += item.Height;
            }
            ave /= Data.Count;
            Average = $"Average: {ave}";
        }
    }
}
