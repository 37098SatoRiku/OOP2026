using System.Diagnostics.Contracts;

namespace Section01 {
    internal class Program {
        static private Dictionary<string, string> prefOfficeDict = new Dictionary<string, string>();
        static void Main(string[] args) {
            string? pref, prefCaptalLocation;
            Console.WriteLine("県庁所在地の登録【入力終了:Ctrl + Z】");
            while(true) {
                //①都道府県の入力
                Console.Write("都道府県:");
                pref = Console.ReadLine();
                if(pref == null) break;  //無限ループを抜ける(Ctrl + Z)

                //②県庁所在地の入力;
                Console.Write("県庁所在地:");
                prefCaptalLocation = Console.ReadLine();
                if(prefCaptalLocation is null) continue;

                //③県庁所在地登録処理
                if(prefOfficeDict.ContainsKey(pref)) {
                    Console.Write("上書きしますか?(y/n) :");
                    var yn = Console.ReadLine();
                    if(yn != "y") {
                        continue;
                    }
                }
                prefOfficeDict[pref] = prefCaptalLocation;
                Console.WriteLine();
            }

            Boolean endFlag = false; //終了フラグ（メニューの無限ループを抜ける用
            while(!endFlag) {
                switch(menuDisp()) {
                    case 1:       //一覧表示出力
                        allDisp();
                        break;
                    case 2:
                        searchPrefCaptalLocation();
                        break;
                    default:
                        endFlag = true;
                        break;
                }

            }
        }
        public static int menuDisp() {
            Console.Write("****メニュー****\n1:一覧表示\n2:検索\n9:終了\n>");
            return int.TryParse(Console.ReadLine(), out var result) ? result : 9;

        }

        public static void allDisp() {
            foreach(var item in prefOfficeDict) {
                Console.WriteLine($"{item.Key}の県庁所在地は{item.Value}です。\n");
            }
        }

        public static void searchPrefCaptalLocation() {
            Console.Write("都道府県:");
            var key = Console.ReadLine();
            if(key is null) return;
            var results = prefOfficeDict.Where(x => x.Key.Contains(key));
            if(results.Any()) {
                foreach(var item in results) {
                    Console.WriteLine($"{item.Key}の県庁所在地は{item.Value}です。\n");
                }
            } else {
                Console.WriteLine("登録されていません");
            }
        }
    }
}