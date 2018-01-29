using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ProgramLogicUtilits
{
   public class TabletsFileUtils
    {
        public static List<Tablets> StrToTabletsList(string arrStr)
        {
            List<Tablets> tabletsList = new List<Tablets>();

            string[] fileLines = arrStr.Split(
                new string[] { Environment.NewLine }, 
                StringSplitOptions.RemoveEmptyEntries
            );

            foreach (string line in fileLines)
                
            {
                //разбили каждую строку на слова
                string[] parts = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string name = "";
                int right = parts.Length - 3;
                for (int i = 0; i < right; i++)
                {
                    name+= parts[i];

                    if (i != right - 1)
                        name += " ";
                }

                int coast = int.Parse(parts[parts.Length-1]);
                int quality = int.Parse(parts[parts.Length - 2]);
                int memory = int.Parse(parts[parts.Length - 3]);

                tabletsList.Add(new Tablets { Model = name, AmoutOfMemory = memory, Raiting = quality, Coast = coast });
            }
            return tabletsList;
        }

        public static string TabletsListToStr(List<Tablets> tablets)
        {
            string resulttablets = "";
            foreach (Tablets elemenList in tablets)
            {
                resulttablets += elemenList.Model+" "+ elemenList.AmoutOfMemory+
                    " "+elemenList.Raiting+" "+elemenList.Coast+" " + Environment.NewLine;
            }

            return resulttablets;
        }
    }
}
