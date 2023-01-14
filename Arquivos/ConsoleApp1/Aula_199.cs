//namespace Aula_199 {
//    public class Program {
//        public static void Main(string[] args) {
//            string path = @"C:\Users\mgarodrigues\Desktop\pastinha";

//            try {

//                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
//                Console.WriteLine("FOLDERS: ");
//                foreach (string folder in folders)
//                    Console.WriteLine(folder);

//                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
//                Console.WriteLine("FILES: ");
//                foreach (string file in files)
//                    Console.WriteLine(file);

//                Directory.CreateDirectory($"{path}/novaPastinha");

//            } catch (IOException error) {
//                Console.WriteLine("An error ocurred");
//                Console.WriteLine(error.Message);
//            }
//        }
//    }
//}