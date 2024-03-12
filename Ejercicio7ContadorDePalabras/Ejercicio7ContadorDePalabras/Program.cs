namespace Ejercicio7ContadorDePalabras
{
    /// <summary>
    /// Clase principal de la aplicación
    /// 120324 - dom
    /// </summary>
    class Program
    {
        /// <summary>
        /// Método principal de la aplicación
        /// 120324 - dom
        /// </summary>
        static void Main()
        {
            string ej = "Esta es una cadena de ejemplo para contar palabras";
            int contadordepalabras = CountWords(ej);
            Console.WriteLine($"Número de palabras: {contadordepalabras}");
        }

        static int CountWords(string ej)
        {
            string[] palabras = ej.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return palabras.Length;
        }
    }
}