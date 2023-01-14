//namespace Aula_197 {
//    public class Program {
//        public static void Main(string[] args) {
//            string path = @"C:\Users\mgarodrigues\Desktop\Horários.txt";

//            try {
//                using StreamReader streamReader = File.OpenText(path);

//                while (!streamReader.EndOfStream)
//                    Console.WriteLine(streamReader.ReadLine());
//            } catch (IOException error) {
//                Console.WriteLine("An error ocurred");
//                Console.WriteLine(error.Message);
//            }
//        }
//    }
//}