using System;
using System.IO;
using Markdig;

namespace RedLineProject.Classes
{
    public class FileWorker
    {
        public static void WriteFile(int length, int width, ref int[,] field)
        {
            using (StreamWriter file = new StreamWriter("my.txt", true))
            {
                for (int i = 0; i < width; ++i)
                {
                    for (int j = 0; j < length; ++j)
                    {
                        //Encoding.ASCII.GetString(BitConverter.GetBytes(field[i, j])));
                        file.Write(field[i, j].ToString());
                    }
                    file.WriteLine();
                }
                file.WriteLine("__________________________________________");
                file.WriteLine();
            }
        }

        public static void ClearData()
        {
            File.Delete("my.txt"); // При запуске программы удаляем файл с расположением деталей.
        }

        public static string GetDocs()
        {
            string text = File.ReadAllText(Environment.CurrentDirectory + @"\docs\for_users.md");
            var result = Markdown.ToHtml(text);

            return result;
        }
    }
}
