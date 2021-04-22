# Arrow Functions, Lambdas, Actions, Functions and Predicates

## Arrow Function
Una funcion que se compone de un/unos parametro/s y se le agrega una flecha para indicar que es una funcion. Se le puede especificar un valor
de retorno, y ademas se le puede especificar cual o cuales son los tipos de los parametros que recibe. Si cuenta con mas de una instruccion,
no debe ser una arrow function sino una funcion normal.

```csharp
// Arrow Function with return value
public bool CheckIfWeekend(string day) => 
return day == "saturday" || day == "sunday";

// Void Arrow Function
public void PrintInLowerCase(string word) =>
Console.WriteLine(word.ToLower());
```

## Lambda
La lambda es un tipo de [Arrow Function](#arrow-function) en la que no se debe escribir ni su tipo de acceso, ni el tipo del valor de retorno, y tampoco los tipos de los parametros (en caso reciba alguno). Tienden a utilizarse cuando se debe enviar un [Action](#action), [Function](#function) o [Predicate](#predicate) como parametros. 

Las lambdas infieren el tipo que debe asignarsele al argumento o los argumentos gracias a la anotacion en la declaracion de la coleccion o el contexto en el que se trabaje.

*PD: Puede estar compuesta por mas de una instruccion.*
Ejemplo:

```csharp

// Asumiendo que tenemos una lista de estudiantes

var students = new List<Student>();

studens.ForEach(st => 
{
    if(st.subjects.Count > 4)
        Console.WriteLine("Lleva una carga justa");
    else
        Console.WriteLine("Lleva una carga pesada");
});

```

## Action
Un action es un tipo de [Arrow Function](#arrow-function) que no retorna un valor.

```csharp
// Manera explicita
Action<int, int> AddNumbers = (int a, int b) => 
{
    Console.WriteLine(a + b);
};

```

## Predicate
Un predicate es un tipo de [Arrow Function](#arrow-function) que retorna un valor booleano.

```csharp
// Manera explicita
Predicate<int, int> CheckIfEquals = (int a, int b) => 
{
    return a == b;
};

```

## Function
Un function es un tipo de [Arrow Function](#arrow-function) que retorna un valor cualquiera (de preferencia diferente de un booleano).

```csharp
// Manera explicita
Function<string, int, double> ConcatenateMessage = (int a, double b) => 
{
    return $"El int es {a} y el double es {b}";
};

```

### Notas

* Es posible mandar una variable de tipo [Action](#action), [Function](#function) o [Predicate](#predicate) como parametro. Ejemplo:

```csharp
// Asumiendo una lista de enteros

Predicate<int> CheckIfEven = (int a) => 
{
    return a % 2 == 0;
};

intList.RemoveAll(CheckIfEven);

```
* Cuando se quiere almacenar un [Action](#action), [Function](#function) o [Predicate](#predicate) en una variable, no se puede hacer uso de **var**