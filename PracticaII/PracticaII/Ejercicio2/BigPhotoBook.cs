using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaII.Ejercicio2
{
    class BigPhotoBook : PhotoBook
    {
        public BigPhotoBook() : base(64)
        {
            // El constructor de BigPhotoBook llama al constructor de PhotoBook con 64 páginas
        }
    }
}
