using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLogicUtilits
{
    /*
     18.Прайс-лист содержит следующую информацию о планшетах:
     название модели, объем памяти, рейтинг модели среди пользователей (цифра от 1 до 5), стоимость. 
     У вас есть N денег.
     Надо купить K самых дешевых планшетов с объемом памяти не ниже M и рейтингом не R (призы победителям олимпиады). 
     Какие планшет вы выберете и сколько денег вы потратите?
    */
    public class Tablets
    {
        //Поля класса (по усл.)
        public string Model { get; set; } //модель планшета

        public int _raiting;

        public int Raiting
        {
            get
            {
                return _raiting;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Рейтинг не может быть отрицательной");
                }

                _raiting = value;
            }
        } //объем памяти



        public int _amoutofmemory;

        public int AmoutOfMemory
        {
            get
            {
                return _amoutofmemory;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Кол-во памяти  не может быть отрицательной");
                }

                _amoutofmemory = value;
            }
        } //объем памяти


        public int _coast;

        public int Coast {
            get {
                return _coast;
            }
            set {
                if (value <= 0)
                {
                    throw new Exception("Цена не может быть отрицательной");
                }

                _coast = value;
            }
        } //стоимость

        //Конструктор
        //public Tablets (string _model, int _amountofmemory, int _raiting, int _coast)
        //{
        //    this.Model = _model;
        //    this.AmoutOfMemory = _amountofmemory;
        //    this.Raiting = _raiting;
        //    this.Coast = _coast;
        //}

    }
    
}
