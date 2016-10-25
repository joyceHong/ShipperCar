using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipperCar
{
    public class OrderShiiperCar
    {
        private double singlePrice = 100; //單本價

        private Dictionary<int, double> SettingDiscount() {
            try
            {
                Dictionary<int, double> discount = new Dictionary<int, double>();
                discount[0] = 1;
                discount[1] = 0.95; //第二本 打5%
                discount[2] = 0.90; //第三本 打10%
                discount[3] =0.8; //第四本 打20%
                discount[4] = 0.75; //第四本 打25%
                return discount;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
        public double TotalValue(List<Book>books) {
            try
            {
                double totalSum = 0;
                Dictionary<int, double> discount = SettingDiscount();
                int maxQuantity = books.Max(x => x.Quantity);
                int versionCounts = 0;
                while (maxQuantity > 0) {
                    versionCounts = books.Where(q => q.Quantity >= maxQuantity).GroupBy(g => g.Version).Count();
                    totalSum += versionCounts * singlePrice * discount[versionCounts - 1];//取得折扣
                    maxQuantity--;
                }
                return totalSum;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
