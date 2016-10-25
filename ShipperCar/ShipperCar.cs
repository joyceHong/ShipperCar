using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipperCar
{
    public class OrderShiiperCar
    {
        
        public int TotalValue(List<Book>books) {
            try
            {

                return books.Sum(x => x.Quantity) * 100;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
