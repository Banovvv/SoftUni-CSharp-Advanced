using System.IO;

namespace _03.CopyBinaryFile
{
    public class CopyBinaryFile
    {
        static void Main(string[] args)
        {
            string inputPath = @"..\..\copyMe.png";
            string outputPath = @"..\..\copyMe-copy.png";

            CopyFile(inputPath, outputPath);
        }

        public static void CopyFile(string inputFilePath, string outputFilePath)
        {
            using (FileStream reader = new FileStream(inputFilePath, FileMode.Open))
            {
                byte[] buffer = new byte[reader.Length];

                reader.Read(buffer, 0, buffer.Length);

                using (FileStream writer = new FileStream(outputFilePath, FileMode.Create))
                {
                    writer.Write(buffer, 0, buffer.Length);
                }
            }
        }
    }
}
