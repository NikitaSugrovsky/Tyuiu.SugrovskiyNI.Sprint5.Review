using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.SugrovskiyNI.Sprint5.TaskReview.V24.Lib;

namespace Tyuiu.SugrovskiyNI.Sprint5.TaskReview.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Сугровский Н. И. | ИИПб-23-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Sprint5.Review                                                               *");
            Console.WriteLine("* Итоговая контрольная                                                         *");
            Console.WriteLine("* Задание #7                                                                   *");
            Console.WriteLine("* Вариант #24                                                                  *");
            Console.WriteLine("* Выполнил: Сугровский Никита Игоревич | ИИПб-23-1                             *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask7V5.txt (файл взять из архива     *");
            Console.WriteLine("* согласно вашему варианту. Создать папку в ручную С:\\DataSprint5\\   и       *");
            Console.WriteLine("* скопировать в неё файл)  в котором есть набор символьных данных.Заменить все *");
            Console.WriteLine("* русские слова на слово слово                                                 *");
            Console.WriteLine("* сохранить в файл OutPutDataFileTask7V24.txt.                                 *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");

            string path = $@"{Directory.GetCurrentDirectory()}\InPutDataFileTask7V24.txt";
            string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutPutDataFileTask7V24.txt";

            Console.WriteLine("Данные находятся в файле: " + path);


            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("Находится в файле: ");
            pathSaveFile = ds.LoadDataAndSave(path);
            Console.WriteLine("Замени все русские слова на слово слово " + pathSaveFile);
            Console.ReadKey();
        }
    }
}
