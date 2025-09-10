// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


var (valor1, valor2, valor3) = (true, true, true);

bool resultAnd = valor1 && valor2 && valor3;
Console.WriteLine(resultAnd);

bool resultOr = valor1 || valor2 || valor3;
Console.WriteLine(resultOr);

bool resultandOr = (valor1 && valor2) || valor3;
Console.WriteLine(resultandOr);

bool resultNot = !valor1;
Console.WriteLine(resultNot);

bool resultXor = valor1 ^ valor2 ^ valor3;
Console.WriteLine(resultXor);





//&& Devuelve verdadero si ambos operandos son verdaderos.
//|| Devuelve verdadero si al menos uno de los operandos es verdadero.
//! Invierte el valor booleano del operando.
//^ Devuelve verdadero si sólo uno de los operandos es verdadero.