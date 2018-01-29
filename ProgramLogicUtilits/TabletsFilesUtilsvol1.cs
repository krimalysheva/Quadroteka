using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProgramLogicUtilits
{
    public class TabletsFilesUtilsvol1
    {
        public static List<Tablets> ReadTablets(string path)
        {
            string[] tabletsSTR = File.ReadAllLines(path);
            List<string[]> tabletsLISTstr = new List<string[]>();
            for (int i = 0; i < tabletsSTR.Length; i++)
            {
                tabletsLISTstr.Add(tabletsSTR[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
            }
                List<Tablets> result = new List<Tablets>();
                for (int i = 0; i < tabletsLISTstr.Count(); i++)
                {
                    Tablets tablets = new Tablets( tabletsLISTstr[i][0].ToString(), Convert.ToInt32(tabletsLISTstr[i][1]), Convert.ToInt32(tabletsLISTstr[i][2]),
                                                    Convert.ToInt32(tabletsLISTstr[i][3])
                                                    );
                    result.Add(tablets);
                }
                return result;
            }
        public static void WriteTablets(string path, List<Tablets> list)
        {
            List<string[]> listSTRmass = new List<string[]>();
            for (int i = 0; i < list.Count(); i++)
            {
                listSTRmass.Add(new string[] { list[i].Model.ToString(), list[i].AmoutOfMemory.ToString(),
                                            list[i].Raiting.ToString(), list[i].Coast.ToString()
                                        });
            }
            string[] STRmass = new string[listSTRmass.Count()];
            for (int i = 0; i < listSTRmass.Count(); i++)
            {
                STRmass[i] = String.Join(" ", listSTRmass[i]);
            }

            File.WriteAllLines(path, STRmass);
        }
    }
}
