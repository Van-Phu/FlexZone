using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymGenZ.PModels
{
    internal class MPaymentProduct
    {
        public int id { get; set; }
        public int IDProduct { get; set; }
        public string NameProduct { get; set; }
        public int PriceProduct { get; set; }
        public int CountProduct { get; set; }
        public string payDay { get; set; }
       

    }
}
