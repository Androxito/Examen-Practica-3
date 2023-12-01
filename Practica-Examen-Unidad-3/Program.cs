namespace Practica_Examen_Unidad_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Listas lista = new Listas();
            Persona persona = new Persona();
            int opcion = 0;
            string opcionS = "";
            string nombre = "";
            int edad = 0;
            while(opcion != 4)
            {
                Console.WriteLine("Seleccione una opcion");
                Console.WriteLine("1 Insertar Nodo al Final\n" +
                    "2 Insertar Nodo al inicio\n" +
                    "3 Buscar\n" +
                    "4 Mostrar\n" +
                    "5 Salir");
                opcionS = Console.ReadLine();
                if(opcionS == "")
                {
                    Console.WriteLine("Ingrese un valor, intente de nuevo");
                }
                else
                {
                    switch (opcionS)
                    {
                        case "1":
                            Console.WriteLine("Ingresa un nombre");
                            nombre = Console.ReadLine();
                            Console.WriteLine("Ingrese la edad");
                            edad = Convert.ToInt32(Console.ReadLine());
                            persona = new Persona
                            {
                                Nombre = nombre,
                                Edad = edad
                            };
                            lista.InsertarAlInicio(persona);
                            break;
                        case "2":
                            Console.WriteLine("Ingresa un nombre");
                            nombre = Console.ReadLine();
                            Console.WriteLine("Ingrese la edad");
                            edad = Convert.ToInt32(Console.ReadLine());
                            persona = new Persona
                            {
                                Nombre = nombre,
                                Edad = edad
                            };
                            lista.InsertarAlInicio(persona);
                            break;
                        case "3":
                            Console.WriteLine("Ingrese el nombre que busca");
                            nombre = Console.ReadLine();
                            lista.BuscarNodo(nombre);
                            break;
                        case "4":
                            lista.MostrarLista();
                            break;
                        case "5":
                            opcion = Convert.ToInt32(opcionS);
                            break;
                        default:
                            Console.WriteLine("No contemplado");
                            break;
                    }
                    }
                }
        }
    }
}