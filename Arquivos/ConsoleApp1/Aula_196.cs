//namespace Aula_196 {
//    public class Program {
//        public static void Main(string[] args) {
//            string path = @"C:\Users\mgarodrigues\Desktop\Horários.txt";

//            StreamReader? streamReader = null;

//            try {
//                streamReader = File.OpenText(path);

//                while (!streamReader.EndOfStream)
//                    Console.WriteLine(streamReader.ReadLine());

//            } catch (IOException error) {
//                Console.WriteLine("An error ocurred");
//                Console.WriteLine(error.Message);
//            } finally {
//                if (streamReader != null) streamReader.Close();
//            }
//        }
//    }
//}