using Microsoft.VisualBasic.FileIO;
using System;
using System.IO;
namespace DirectoryInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region CREATE .gitignore

            //  string path = @"C:\DirectoryInfo\DirectoryInfo\.gitignore";
            //  if(!Directory.Exists(path))
            //  {
            //    Directory.CreateDirectory(path);
            //  }
            #endregion

            #region FIND bin And obj

            //  string projectPath = @"path\to\project";
            //  string[] directories = Directory.GetDirectories(projectPath, "*", SearchOption.AllDirectories);
            //  foreach (string directory in directories)
            //  {
            //  string folderName = Path.GetFileName(directory);
            //  if (folderName == "bin" || folderName == "obj")
            //  {
            //      Console.WriteLine(directory);
            //  }
            #endregion


            #region FIND .exe files

            //   string projectPath = @"C:\DirectoryInfo\.gitignore";
            //   string[] exeFiles = Directory.GetFiles(projectPath, "*.exe", SearchOption.AllDirectories);
            //   foreach (string file in exeFiles)
            //   {
            //       string fileName = Path.GetFileName(file);
            //       Console.WriteLine(fileName);
            //   }
            #endregion


            #region Delete bin and obj files

            //  string path = @"C:\DirectoryInfo\DirectoryInfo"; 
            //  string[] directories = { "bin", "obj" }; 

            //  foreach (string directory in directories)
            //  {
            //      string folderPath = Path.Combine(path, directory);
            //
            //      if (Directory.Exists(folderPath))
            //      {
            //          Directory.Delete(folderPath, true);
            //          Console.WriteLine($"{folderPath} o'chirildi.");
            //   }
            //      else
            //      {
            //          Console.WriteLine($"{folderPath} topilmadi.");
            //      }
            //   }
            #endregion


            #region Berilgan path ga mos papka ichida nimalar borligini aniqlaydigan method.

            //    string path = @"C:\GitHub\DirectoryInfo";

            //    string result = CheckDirectoryContents(path);
            //    Console.WriteLine(result);
            //}


            //public static string CheckDirectoryContents(string path)
            //{
            //    bool hasFiles = false;
            //    bool hasDirectories = false;

            //    if (Directory.Exists(path))
            //    {

            //        string[] files = Directory.GetFiles(path);
            //        if (files.Length > 0)
            //        {
            //            hasFiles = true;
            //        }


            //        string[] directories = Directory.GetDirectories(path);
            //        if (directories.Length > 0)
            //        {
            //            hasDirectories = true;
            //        }
            //    }


            //    if (hasFiles && hasDirectories)
            //    {
            //        return "Papka va fayllar bor";
            //    }
            //    else if (hasFiles)
            //    {
            //        return "Fayllar bor";
            //    }
            //    else if (hasDirectories)
            //    {
            //        return "Papkalar bor";
            //    }
            //    else
            //    {
            //        return "Papka bo'sh";
            //    }

            //}
            #endregion


            #region Berilgan matnli fayl ichida nechta qator borligini topuvchi dastur.



            //    string filePath = @"C:\DirectoryInfo\file.txt";
            //    int lineCount = CountFileLines(filePath);
            //    Console.WriteLine($"Faylda {lineCount} qator mavjud.");
            //}

            //     public static int CountFileLines(string filePath)
            //{
            //    int lineCount = 0;

            //    if (File.Exists(filePath))
            //    {
            //        using (StreamReader reader = new StreamReader(filePath))
            //        {
            //            while (reader.ReadLine() != null)
            //            {
            //                lineCount++;
            //            }
            //        }
            //    }

            //    return lineCount;
            //   }

            #endregion


            #region Berilgan fayl(ixtiyoriy formatdagi)dan nusxa oluvchi dastur

            //    string sourceFilePath = @"C:\DirectoryInfo\file.txt"; 
            //    string destinationFilePath = @"C:\dell\file.txt"; 

            //    bool success = CopyFile(sourceFilePath, destinationFilePath);
            //    if (success)
            //    {
            //        Console.WriteLine("Fayl nusxa olindi.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Fayl nusxa olishda xatolik yuz berdi.");
            //    }
            //}

            //public static bool CopyFile(string sourceFilePath, string destinationFilePath)
            //{
            //    try
            //    {
            //        if (File.Exists(sourceFilePath))
            //        {
            //            File.Copy(sourceFilePath, destinationFilePath, true);
            //            return true;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Bergan manba fayl topilmadi.");
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine($"Nusxa olishda xatolik yuz berdi: {ex.Message}");
            //    }

            //    return false;

            //}
            #endregion



            #region Ikkita matnli fayl ichidagilarni birlashtirib uchunchi faylga yozadigan dastur tuzing

            //    string firstFilePath = @"C:\DirectoryInfo\file.txt"; 
            //    string secondFilePath = @"C:\dell\file.txt"; 
            //    string mergedFilePath = @"C:\User\Public\file.txt";

            //    bool success = MergeFiles(firstFilePath, secondFilePath, mergedFilePath);
            //    if (success)
            //    {
            //        Console.WriteLine("Fayllar birlashtirildi.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Fayllarni birlashtirishda xatolik yuz berdi.");
            //    }
            //}

            //public static bool MergeFiles(string firstFilePath, string secondFilePath, string mergedFilePath)
            //{
            //    try
            //    {
            //        if (File.Exists(firstFilePath) && File.Exists(secondFilePath))
            //        {
            //            string firstContent = File.ReadAllText(firstFilePath);
            //            string secondContent = File.ReadAllText(secondFilePath);

            //            string mergedContent = firstContent + secondContent;

            //            File.WriteAllText(mergedFilePath, mergedContent);
            //            return true;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Bergan fayllardan bittasi yoki ikkisi ham topilmadi.");
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine($"Fayllarni birlashtirishda xatolik yuz berdi: {ex.Message}");
            //    }

            //    return false;



            //}
            #endregion







        }
    }
}
