using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramLogicUtilits;
namespace ConsoleUtils
{
    public class ListCosoleUtils
    {
        public static List<Tablets> ReadList()
        {
            return (IOUtils.AskQuestion("Считать из файла (y/n): ")) ? ReadListFromFile() : ReadListFromConsole();
        }

        public static List<Tablets> ReadListFromFile()
        {
            List<Tablets> tablets = new List<Tablets>();

            while (true)
            {
                try
                {
                    string path = IOUtils.ReadValueFromConsole<string>("путь к файлу");

                    string listText = FileUtils.ReadStringFromFile(path);

                    List<string> rowsList = ConvertUtils.StrToList<string>(listText, new char[] { '\n' });

                    for (int i = 0; i < rowsList.Count; i++)
                    {
                        List<string> templist = ConvertUtils.StrToList<string>(rowsList[i]);

                        string tabletName = "";
                        for (int wordIndex = 0; wordIndex < templist.Count - 3; wordIndex++)
                        {
                            tabletName += templist[wordIndex];
                        }

                        int tabletMemory = Convert.ToInt32(templist[templist.Count - 3]);
                        int tabletRaiting = Convert.ToInt32(templist[templist.Count - 2]);
                        int tanbletCoast = Convert.ToInt32(templist[templist.Count - 1]);

                        tablets.Add(new Tablets { Model = tabletName, AmoutOfMemory = tabletMemory, Raiting = tabletRaiting, Coast = tanbletCoast });

                    }
                    return tablets;
                }
                catch (Exception e)
                {
                    // Если во время считывания из файла ошибка, то просим ввести путь ещё раз
                    Console.WriteLine("Невозможно считать из этого файла");
                }
            }
        }

        public static List<Tablets> ReadListFromConsole()
        {
            List<Tablets> tablets = new List<Tablets>();

            while (true)
            {
                try
                {
                    int tabletsCount = IOUtils.ReadValueFromConsole<int>("количество планшетов", (x) => x > 0);

                    for (int i = 0; i < tabletsCount; i++)
                    {
                        Console.WriteLine("***********Введите ваши данные планешета №"+ (i+1) + " ***********");
                        string tabletName = IOUtils.ReadValueFromConsole<string>("название планшета");
                        //анонимные функции
                            int tabletMemory = IOUtils.ReadValueFromConsole<int>("объем памяти", (x) => x > 0 && (x&(~x+1)) == x);
                            int tabletRaiting = IOUtils.ReadValueFromConsole<int>("рейтинг", (x) => x > 0);
                            int tabletCoast = IOUtils.ReadValueFromConsole<int>("цену", (x) => x > 0);


                        tablets.Add(new Tablets { Model= tabletName, AmoutOfMemory= tabletMemory, Raiting=tabletRaiting, Coast=tabletCoast });
                    }
                    return tablets;
                }
                catch (Exception e)
                { 
                }
            }
        }

        public static void WriteListToFile(List<Tablets> list)
        {
            while (true)
            {
                try
                {
                    string path = IOUtils.ReadValueFromConsole<string>("путь к файлу");

                    string result = "";
                    for (int i = 0; i < list.Count; i++)
                    {
                        result += list[i].Model + " " +
                            list[i].AmoutOfMemory + " " +
                            list[i].Raiting + " " +
                            list[i].Coast + "\r\n";
                    }

                    FileUtils.WriteStringToFile(path, result);
                    return;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Файл недоступен");
                }
            }
        }

        public static void WriteListToConsole(List<Tablets> list)
        {
            string result = "";
            for (int i = 0; i < list.Count; i++)
            {
                result += list[i].Model + " " +
                    list[i].AmoutOfMemory + " " +
                    list[i].Raiting + " " +
                    list[i].Coast + "\n";
            }
            Console.WriteLine(result);
        }
    }
}



