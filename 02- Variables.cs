                                                                 #######Variables basicas#######
using System;

class Program {
    static void Main() {
       //Tenemos 2 tipos de variables (implicitas y explicitas)
      var x = 1; //Implicita
      int y = 10; //Explicita
      int suma = x + y; //Definis la suma con su tipo
      Console.WriteLine("La suma es = {0} ",  suma);
      //El {0} se utiliza como un marcador de posición para indicar dónde se debe insertar el valor 
      //de la variable en la cadena de texto que se va a imprimir en la consola.
    }
}

                                                                #####Dato de tipo flotante#####
using System;

class Program {
    static void Main() {
       float n = 0.5f;
       float temperatura = 25.5f;
       float velocidad = 10.2f;
       float altura = 3.7f;
       float peso = 62.5f;
        //Se usan los tipo flotante para especificarnos con numeros decimales
        //Aunque las variables de tipo float tienen una precisión menor que las variables de tipo double, son más eficientes en términos de uso de memoria y procesamiento, 
        //Por lo que se pueden utilizar en situaciones donde la precisión adicional de las variables de tipo double no es necesaria. 
    }
}
                                                                 #####Dato de tipo doble#####   
/*
El tipo de dato double es similar al tipo de dato float, pero ofrece una mayor precisión, 
ya que puede almacenar números con hasta 15 dígitos decimales de precisión, 
mientras que el tipo de dato float solo puede almacenar números con alrededor de 7 dígitos decimales de precisión.

*/ 
 
 
 
 
 
