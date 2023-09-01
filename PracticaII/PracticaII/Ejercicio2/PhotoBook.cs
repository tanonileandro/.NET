using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaII.Ejercicio2
{
    public class PhotoBook
    {
        protected int numPages;

        public PhotoBook()
        {
            numPages = 16;
        }

        public PhotoBook(int pages)
        {
            numPages = pages;
        }

        public int GetNumberPages()
        {
            return numPages;
        }
    }
}
