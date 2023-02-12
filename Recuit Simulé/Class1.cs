using System.Net;
using Python.Runtime;

namespace PythonCall
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Py.GIL())
            {
                // Importation de la bibliothèque Python nécessaire
                dynamic sys = Py.Import("sys");
                sys.path.append("C:\\path\\to\\python\\library");

                // Chargement du code Python
                dynamic pythonCode = Py.Import("python_code");

              
            }
        }
    }
}



