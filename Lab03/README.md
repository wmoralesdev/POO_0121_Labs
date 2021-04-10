# Named Parameters, Inheritance

## Qué son
Los named parameters son una sintaxis especifica para poder inicializar un parametro en la declaracion de un metodo.

PD: No son exclusivos de C#, ni exclusivos de uso en constructores.

PDD: 

```csharp

static void Main(string[] args)
{
    Console.WriteLine(GetDiscounts(800, 3, 7.5, 10));
    Console.WriteLine(GetDiscounts(900, 0, 0, 10));

    var discount = GetDiscounts(salary: 900, afp: 6.25);

    var discount2 = GetDiscounts(salary: 750, rent: 4);

    var discountTotal = GetDiscounts(salary: 1200, isss: 3, afp: 7.5, rent: 10);
}

// With overloads
// public static int GetDiscounts(double salary, double rent)
// {

// }

// public static int GetDiscounts(double salary, double isss, double afp, double rent)
// {

// }

// Method with named parameters
public static int GetDiscounts(double salary = 0, double isss = 0, double afp = 0, double rent = 0)
{

}

```
-------
## Inheritance

La herencia es un concepto que separa una implementacion de clases, en dos partes: Clase padre, y clases hijas o derivadas.

### Clase padre
La clase padre es la clase base que contiene los elementos, ya sean atributos o metodos que se desea sean compartidos con las clases derivadas.

### Clase hija/derivada
Las clases derivadas son aquellas qyue **heredan** de la clase padre. Heredar implica compartir o tener acceso a los metodos de la clase superior.