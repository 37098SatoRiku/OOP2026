using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCalculator {
    //売上集計クラス
    public class SalesCounter {
        private readonly IEnumerable<Sale> _sales;

        //コンストラクタ
        public SalesCounter(string filePath) {
            _sales = ReadSales(filePath);
        }

        static List<Sale> ReadSales(string filePath) {
            List<Sale> sales = new List<Sale>();
            string[] lines = File.ReadAllLines(filePath);
            foreach(string line in lines) {
                string[] items = line.Split(',');
                Sale sale = new Sale
                {
                    ShopName = items[0],
                    ProductCategory = items[1],
                    Amount = int.Parse(items[2])
                };
                sales.Add(sale);
            }
            return sales;
        }


        //店舗別売上を求める
        public Dictionary<string, int> GetPerStoreSales() {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach(var sale in _sales) {
                if(dict.ContainsKey(sale.ShopName))//既に店舗名が辞書のキーに登録されているか
                    //登録されている場合
                    dict[sale.ShopName] += sale.Amount;//売上を足しこみ
                else
                    //未登録の場合
                    dict[sale.ShopName] = sale.Amount;//新規に売り上げを登録            
            }
            return dict;
        }
    }
}
