
namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            var songs = new List<Song>();
            Console.WriteLine("*****曲の登録*****");
            while(true) {
                Console.Write("曲名:");
                var title = Console.ReadLine();
                if(string.Compare(title, "END", ignoreCase:true) == 0) {
                    Console.WriteLine("");
                    break;
                }
                Console.Write("アーティスト名:");
                var artistname = Console.ReadLine();
                Console.Write("演奏時間(秒):");
                int length = int.Parse(Console.ReadLine());
                songs.Add(new Song(title, artistname, length));
                Console.WriteLine("");
            }
            PrintSongs(songs);
        }
        //Mainメソッド内のPrintSongs(songs);をクリックしてAlt+Enterを押すと以下のメソッドが自動的に作成される
        private static void PrintSongs(List<Song> songs) {
            foreach(var Song in songs) {
                Console.WriteLine($"{Song.Title},{Song.ArtistName},{Song.Length / 60}:{(Song.Length % 60).ToString("00")}");
            }
        }
    }
}
