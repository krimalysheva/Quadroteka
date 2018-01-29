using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLogicUtilits
{
    public class ListClassUtils
    {
        // Поле лист с типом данных планшет 
        public List<Tablets> Tablet { get; set; }

        //Конструктор Лист
        public ListClassUtils(List<Tablets> tablet)
        {
            this.Tablet = tablet;
        }

        public List<Tablets> SelectFirstTablets(List<Tablets> tablets, int k)
        {
            if (k > tablets.Count)
                k = tablets.Count;

            return tablets.GetRange(0, k);
            //необходимо искючение. если ползователь введет значения, превышающие введеные на 1 этапе.
        }

        public List<Tablets> SortTabletsByPrice(List<Tablets> tablets)
        {
            //создали результирующий массив, чтобы не менять свойства
            List<Tablets> result = new List<Tablets>(tablets);

            //отсортировали массив по "возрастанию" цены - для упрощения работы с дальнейшими списками
            result.Sort(delegate (Tablets M1, Tablets M2)
               {
                   if (M1.Coast >= M2.Coast)
                       return 1;

                   return -1;
               });

            return result;
        }

        public List<Tablets> SelectTablesByMemoryAndRating(int minMemory, int minRating)
        {
            List<Tablets> result = new List<Tablets>();

            foreach (Tablets tablet in Tablet)
            {
                if (tablet.AmoutOfMemory >= minMemory && tablet.Raiting >= minRating)
                    result.Add(tablet);
            }

            return result;
        }
    }
}
