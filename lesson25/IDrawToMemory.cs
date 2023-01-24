using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace lesson25
{
    //вывести изображение в буфер памяти
    public interface IDrawToMemory
    {
        void Draw();
    }
}
