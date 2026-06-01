using System.Collections.Immutable;

namespace Section01 {
    internal class Program {
        static void Main(string[] args) {
            //var obj = new PasswordPolicy("aaaaa", "bbbbb");
            //var data = obj.Name;
            var ms = new MySaple();
            var newList = ms.MyList.Add(6).RemoveAt(0);
            ms.MyList.ForEach(n => Console.Write($"{n}"));
            Console.WriteLine();

            newList.ForEach(n => Console.Write($"{n}"));
            Console.WriteLine();
        }
    }

    class MySaple {
        public ImmutableList<int> MyList { get; set; }

        public MySaple() {
            var list = new List<int> ()  { 1,2,3,4,5};
            MyList = list.ToImmutableList();
        }
    }

    class PasswordPolicy {
        //プロパティの初期化
        public int MinimumLength { get; set; } = 8;

        //読み取り専用プロパティ
        public string GivenName { get; private set; } = null!;
        public string FamilyName { get; init; } = null!;

        /*getアクセサーのみを定義した読み取り専用プロパティ
        public string Name {
            get { return FamilyName + " " + GivenName; }
        }*/

        public string Name => FamilyName + " " + GivenName;

        public PasswordPolicy(string familiName, string GivenName) {
            FamilyName = FamilyName;
            GivenName = GivenName;
        }
    }
}
