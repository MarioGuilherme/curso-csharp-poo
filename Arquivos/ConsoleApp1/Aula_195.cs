//namespace Aula_195 {
//    public class Program {
//        public static void Main(string[] args) {
//            string sourcePath = @"C:\Users\mgarodrigues\Desktop\file1.txt";
//            string targetPath = @"C:\Users\mgarodrigues\Desktop\file2.txt";

//            try {
//                FileInfo fileInfo = new(sourcePath);
//                fileInfo.CopyTo(targetPath);
//                string[] lines = File.ReadAllLines(targetPath);

//                foreach (string line in lines)
//                    Console.WriteLine(line);

//            } catch (IOException error) {
//                Console.WriteLine("An error occurred");
//                Console.WriteLine(error.Message);
//            }
//        }
//    }
//}