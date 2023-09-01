// See https://aka.ms/new-console-template for more information
using PracticaII.Ejercicio2;

class Program
{
    static void Main(string[] args)
    {
        // Crear un álbum de fotos por defecto
        PhotoBook albumPorDefecto = new PhotoBook();
        Console.WriteLine("Número de páginas del álbum por defecto: " + albumPorDefecto.GetNumberPages());

        // Crear un álbum de fotos con 24 páginas
        PhotoBook albumCon24Paginas = new PhotoBook(24);
        Console.WriteLine("Número de páginas del álbum con 24 páginas: " + albumCon24Paginas.GetNumberPages());

        // Crear un álbum de fotos grande
        BigPhotoBook albumGrande = new BigPhotoBook();
        Console.WriteLine("Número de páginas del álbum grande: " + albumGrande.GetNumberPages());
    }
}