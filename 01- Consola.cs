using System; //Usamos esa libreria

class Program {
    static void Main() {
		Console.Title = "My title"; //Le pongo un titulo a la consola
		Console.WriteLine("Ingresa un texto"); //Le pido un texto al usuario
		string txtUsuario = Console.ReadLine();  
		Console.WriteLine("El texto recibido es " + txtUsuario); //Concatenamos la variable
		Console.ReadKey(); //Leemos la tecla para que no se cierre automaticamente nuestra consola y llevar un control sobre la misma
    }
}
