using JuegoRuleta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JuegoRuleta.Models
{
    public class ArmaListas : INumeroRuleta
    {
        public List<numerorul> numero;
        public List<numerorul> Devolver(bool Ch1, bool Ch2, bool Ch3, bool Ch4, bool Ch5, bool Ch6, bool Ch7, bool Ch8, bool Ch9, bool Ch10, bool Ch11, bool Ch12, bool Ch13, bool Ch14, bool Ch15, bool Ch16, bool Ch17, bool Ch18, bool Ch19, bool Ch20, bool Ch21, bool Ch22, bool Ch23, bool Ch24, bool Ch25, bool Ch26, bool Ch27, bool Ch28, bool Ch29, bool Ch30, bool Ch31, bool Ch32, bool Ch33, bool Ch34, bool Ch35, bool Ch36)
        {
            numero = new List<numerorul>();
            if (Ch1)
            {
                numero.Add(new numerorul() { indice = 1, name = 1 });
            }
            if (Ch2)
            {
                numero.Add(new numerorul() { indice = 2, name = 2 });
            }
            if (Ch3)
            {
                numero.Add(new numerorul() { indice = 3, name = 3 });
            }
            if (Ch4)
            {
                numero.Add(new numerorul() { indice = 4, name = 4 });
            }
            if (Ch5)
            {
                numero.Add(new numerorul() { indice = 5, name = 5 });
            }
            if (Ch6)
            {
                numero.Add(new numerorul() { indice = 6, name = 6 });
            }
            if (Ch7)
            {
                numero.Add(new numerorul() { indice = 7, name = 7 });
            }
            if (Ch8)
            {
                numero.Add(new numerorul() { indice = 8, name = 8 });
            }
            if (Ch9)
            {
                numero.Add(new numerorul() { indice = 9, name = 9 });
            }
            if (Ch10)
            {
                numero.Add(new numerorul() { indice = 10, name = 10 });
            }
            if (Ch11)
            {
                numero.Add(new numerorul() { indice = 11, name = 11 });
            }

            if (Ch12)
            {
                numero.Add(new numerorul() { indice = 12, name = 12 });
            }

            if (Ch13)
            {
                numero.Add(new numerorul() { indice = 13, name = 13 });
            }

            if (Ch14)
            {
                numero.Add(new numerorul() { indice = 14, name = 14 });
            }

            if (Ch15)
            {
                numero.Add(new numerorul() { indice = 15, name = 15 });
            }

            if (Ch16)
            {
                numero.Add(new numerorul() { indice = 16, name = 16 });
            }

            if (Ch17)
            {
                numero.Add(new numerorul() { indice = 17, name = 17 });
            }

            if (Ch18)
            {
                numero.Add(new numerorul() { indice = 18, name = 18 });
            }

            if (Ch19)
            {
                numero.Add(new numerorul() { indice = 19, name = 19 });
            }

            if (Ch20)
            {
                numero.Add(new numerorul() { indice = 20, name = 20 });
            }

            if (Ch21)
            {
                numero.Add(new numerorul() { indice = 21, name = 21 });
            }

            if (Ch22)
            {
                numero.Add(new numerorul() { indice = 22, name = 22 });
            }

            if (Ch23)
            {
                numero.Add(new numerorul() { indice = 23, name = 23 });
            }

            if (Ch24)
            {
                numero.Add(new numerorul() { indice = 24, name = 24 });
            }

            if (Ch25)
            {
                numero.Add(new numerorul() { indice = 25, name = 25 });
            }

            if (Ch26)
            {
                numero.Add(new numerorul() { indice = 26, name = 26 });
            }

            if (Ch27)
            {
                numero.Add(new numerorul() { indice = 27, name = 27 });
            }

            if (Ch28)
            {
                numero.Add(new numerorul() { indice = 28, name = 28 });
            }

            if (Ch29)
            {
                numero.Add(new numerorul() { indice = 29, name = 29 });
            }

            if (Ch30)
            {
                numero.Add(new numerorul() { indice = 30, name = 30 });
            }

            if (Ch31)
            {
                numero.Add(new numerorul() { indice = 31, name = 31 });
            }

            if (Ch32)
            {
                numero.Add(new numerorul() { indice = 32, name = 32 });
            }

            if (Ch33)
            {
                numero.Add(new numerorul() { indice = 33, name = 33 });
            }

            if (Ch34)
            {
                numero.Add(new numerorul() { indice = 34, name = 34 });
            }

            if (Ch35)
            {
                numero.Add(new numerorul() { indice = 35, name = 35 });
            }

            if (Ch36)
            {
                numero.Add(new numerorul() { indice = 36, name = 36 });
            }
            return numero;
        }
    }
}