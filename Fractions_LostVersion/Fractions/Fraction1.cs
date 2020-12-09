using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractions 
{
    class Fraction1 
    {
        //private int _denumerator;
        public int Denumerator { get; private set; }
        public int Numerator { get; private set; }
        public string OperationName { get; private set; }
        private Fraction1 _result;
        public Fraction1 getResult() => _result;
        private Fraction1() { }
        public Fraction1(int numerator, int denumerator)
        {
            if (numerator < 0 && denumerator < 0||denumerator<0)
            {
                numerator *= -1;
                denumerator *= -1;
            }
   
            Numerator = numerator;
            if (denumerator != 0)
                Denumerator = denumerator;
            else
                throw new ArgumentOutOfRangeException("На ноль делить нельзя");
        }
        public override string ToString() => $"{Numerator}/{Denumerator}";
        public Fraction1 Sum(Fraction1 f1, Fraction1 f2)
        {
            OperationName = "Сумма";
            _result = new Fraction1();
            //проверяю эквивалентность знаменателей
            if (f1.Denumerator == f2.Denumerator)//если одинаковые
            {
                _result.Numerator = f1.Numerator + f2.Numerator;
                _result.Denumerator = f1.Denumerator;
                if (_result.Numerator == 0)
                    _result.Denumerator = _result.Numerator / _result.Denumerator;
                else if (_result.Numerator == 1)
                    NOD = 1;
                else
                {
                    NOD = _result.GCD(_result.Numerator, _result.Denumerator); ;
                    _result.Numerator /= NOD;
                    _result.Denumerator /= NOD;
                }
            }
            else
            {
                int higest_denumenator = f1.Denumerator;
                int lowest_denumenator = f2.Denumerator;//допускаю что так, если не так, то далее есть проверка
                if (higest_denumenator < lowest_denumenator)//проверка если не так
                {
                    higest_denumenator = f2.Denumerator;
                    lowest_denumenator = f1.Denumerator;
                }
                //если бОльший зн делится на меньший без остатка
                if (higest_denumenator % lowest_denumenator == 0)
                {
                    //теперь нужно числитель меньшей дроби умножить на результат деления большего знам. на меньший
                    if (lowest_denumenator == f1.Denumerator)
                        f1.Numerator *= (higest_denumenator / lowest_denumenator);
                    else
                        f2.Numerator *= (higest_denumenator / lowest_denumenator);
                    _result.Numerator = f1.Numerator + f2.Numerator;
                    _result.Denumerator = f1.Denumerator;
                }
                else//если бОльший не делится на меньший без остатка
                {
                    _result.Numerator = (f1.Numerator * f2.Denumerator) + (f2.Numerator * f1.Denumerator);
                    _result.Denumerator = f1.Denumerator * f2.Denumerator;
                }
                if (_result.Numerator == 0)
                    _result.Denumerator = _result.Numerator / _result.Denumerator;
                else if (_result.Numerator != 1)
                    NOD = _result.GCD(_result.Numerator, _result.Denumerator);
                else
                    NOD = 1;
                _result.Numerator /= NOD;
                _result.Denumerator /= NOD;
            }
            return _result;
        }
        public Fraction1 Subtruction(Fraction1 f1, Fraction1 f2)
        {
            _result = new Fraction1();
            OperationName = "Вычитание";//нужно найти НОЗ
            if (f1.Denumerator == f2.Denumerator)//проверяю эквивалентность знаменателей, если равны
            {
                _result.Numerator = (f1.Numerator - f2.Numerator);
                _result.Denumerator = f1.Denumerator;
                if (_result.Numerator == 0)
                    _result.Denumerator = _result.Numerator / _result.Denumerator;
                else if (_result.Numerator != 1)
                    NOD = GCD(_result.Numerator, _result.Denumerator);
                else
                    NOD = 1;
                if (_result.Numerator != 0)
                {
                    _result.Numerator /= NOD;
                    _result.Denumerator /= NOD;
                }
            }
            else
            //если знаменатели не равны //нахожу БОЛЬШИЙ и МЕНЬШИЙ знаменатели
            {
                int higest_denumenator = f1.Denumerator;
                int lowest_denumenator = f2.Denumerator;//допускаю что так, если не так, то далее есть проверка
                if (higest_denumenator < lowest_denumenator)//проверка если не так
                {
                    higest_denumenator = f2.Denumerator;
                    lowest_denumenator = f1.Denumerator;
                }
                //если бОльший зн делится на меньший без остатка
                if (higest_denumenator % lowest_denumenator == 0)
                {
                    //теперь нужно числитель меньшей дроби умножить на результат деления большего знам. на меньший
                    if (lowest_denumenator == f1.Denumerator)
                        f1.Numerator *= (higest_denumenator / lowest_denumenator);
                    else
                        f2.Numerator *= (higest_denumenator / lowest_denumenator);
                    _result.Numerator = f1.Numerator - f2.Numerator;
                    _result.Denumerator = f1.Denumerator;
                }
                else//если бОльший не делится на меньший без остатка
                { _result.Numerator = (f1.Numerator * f2.Denumerator) - (f2.Numerator * f1.Denumerator);
                    _result.Denumerator = f1.Denumerator * f2.Denumerator;
                }
                if (_result.Numerator == 0)
                    _result.Denumerator = _result.Numerator / _result.Denumerator;
                else if (_result.Numerator != 1)
                    NOD = _result.GCD(_result.Numerator, _result.Denumerator);
                else
                    NOD = 1;
                _result.Numerator /= NOD;
                _result.Denumerator /= NOD;
            }
            return _result;
        }
        public Fraction1 Multiplication(Fraction1 f1, Fraction1 f2)
        {
            _result = new Fraction1();
            OperationName = "Умножение";
            _result.Numerator = f1.Numerator * f2.Numerator;
            _result.Denumerator = f1.Denumerator * f2.Denumerator;
            int NOD = GCD(_result.Numerator, _result.Denumerator);
            _result.Numerator /= NOD;
            _result.Denumerator /= NOD;

            return _result;
        }
        public Fraction1 Division(Fraction1 f1, Fraction1 f2)
        {
            _result = new Fraction1();
            OperationName = "Деление";
            _result.Numerator = f1.Numerator * f2.Denumerator;
            _result.Denumerator = f1.Denumerator * f2.Numerator;
            int NOD = GCD(_result.Numerator, _result.Denumerator);
            _result.Numerator /= NOD;
            _result.Denumerator /= NOD;

            return _result;
        }
        
        //ф-ция поиска НОДа
        private int result, NOD;
        private int GCD(int num, int denum)
        {
            NOD = 0;
            if (num < 0) num *= -1;
            if (denum < 0) denum *= -1;
            if (num < denum)
            {
                int c = num;
                num = denum;
                denum = c;
            }
            while (NOD == 0)
            {
                result = num % denum;
                if (result == 0)
                    NOD = denum;
                else
                {
                    num = denum;
                    denum = result;
                }
            }
            return NOD;
        }
    }
}
