using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson25
{
    class Octagon: IDrawToForm, IDrawToMemory, IDrawToPrinter
    {
        //явно привязать реализации Draw() к конкретным интерфейсам 
        void IDrawToForm.Draw()
        {
            
            Console.WriteLine("Drawing to...."); //вывод на форму
        }

        void IDrawToMemory.Draw()
        {
            Console.WriteLine("Drawing to..."); //вывод в память
        }

        void IDrawToPrinter.Draw()
        {
            Console.WriteLine("Drawing to..."); //вывод на принтер
        }

    }
}
