//namespace Aula_198 {
//    public class Program {
//        public static void Main(string[] args) {
//            string sourcePath = @"C:\Users\mgarodrigues\Desktop\Horários.txt";
//            string targetPath = @"C:\Users\mgarodrigues\Desktop\HoráriosCopia.txt";

//            try {
//                string[] lines = File.ReadAllLines(sourcePath);

//                using StreamWriter streamWrite = File.AppendText(targetPath);

//                foreach (string line in lines)
//                    streamWrite.WriteLine(line.ToLower());

//            } catch (IOException error) {
//                Console.WriteLine("An error ocurred");
//                Console.WriteLine(error.Message);
//            }
//        }
//    }
//}