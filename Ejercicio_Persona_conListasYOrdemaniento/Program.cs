using Ejercicio_Persona_conListasYOrdemaniento;

internal class Program
{
    private static void Main(string[] args)
    {
        Listas li = new Listas();
        Persona persona = new Persona();
        Console.WriteLine("Ingresa el nombre");
        persona.Nombre = Console.ReadLine();
        Console.WriteLine("ingrese la edad");
        persona.Edad = Convert.ToInt32(Console.ReadLine());
        li.InsertarElemento(persona);

        Persona persona2 = new Persona();
        Console.WriteLine("Ingresa el nombre");
        persona2.Nombre = Console.ReadLine();
        Console.WriteLine("ingrese la edad");
        persona2.Edad = Convert.ToInt32(Console.ReadLine());
        li.InsertarElemento(persona2);

        Persona persona3 = new Persona();
        Console.WriteLine("Ingresa el nombre");
        persona3.Nombre = Console.ReadLine();
        Console.WriteLine("ingrese la edad");
        persona3.Edad = Convert.ToInt32(Console.ReadLine());
        li.InsertarElemento(persona3);

        Console.WriteLine("ingrese el nombre a buscar: ");
        string nombre = Console.ReadLine();
        li.BuscarNombre(nombre);
        li.ImprimirLista();

        li.EliminarElemDeseado("an");
        li.ImprimirLista();
    }
}