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
                Book currentBook = null;
                Book preBook = null;
                int currentIndex = 0;
                int discountPercent = 0;
                Dictionary<int, double> discount = SettingDiscount();
                foreach (Book book in books.OrderBy(x => x.Version))
                {
                    currentBook = book;
                    if (currentIndex != 0)
                    {
                        preBook = books[currentIndex - 1];
                        if (preBook.Version != currentBook.Version)
                        {
                            discountPercent += 1;
                        }
                    }
                    currentIndex++;
                }
                return books.Sum(x=>x.Quantity)*singlePrice* discount[discountPercent];
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
