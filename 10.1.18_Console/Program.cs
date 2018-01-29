using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramLogicUtilits;
using ConsoleUtils;

namespace _10._1._18_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            int K, M, R;
            while (true)
            {
                List<Tablets> test = ListCosoleUtils.ReadList();

                    K = (int)IOUtils.ReadValueFromConsole<uint>("количество отбираемых планшетов");

                if (K == 0) continue;

                    M = (int)IOUtils.ReadValueFromConsole<uint>("минимальный объем памяти");
                if (M == 0) continue;
                    R = (int)IOUtils.ReadValueFromConsole<uint>("минимальный рейтинг (1,2,3,4,5)");
                if (R == 0) continue; 
                    
                    ListClassUtils utils = new ListClassUtils(test);
                    List<Tablets> sortedList = utils.SortTabletsByPrice(utils.SelectTablesByMemoryAndRating(M, R));
                    List<Tablets> result = utils.SelectFirstTablets(sortedList, K);
                    ListCosoleUtils.WriteListToConsole(result);
                
                if (IOUtils.AskQuestion("Сохранить в файл? (y/n)"))
                {
                    ListCosoleUtils.WriteListToFile(result);
                }

                if (!IOUtils.AskQuestion("Продожить? (y/n)"))
                    break;
            }
        }
    }
}
