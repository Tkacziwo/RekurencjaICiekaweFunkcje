// See https://aka.ms/new-console-template for more information


using RekurencjaICiekaweFunkcje;

SolvedTasks solvedTasks = new();

//Zad 0. Ciekawe zadanie wykrywanie palindromu
/* Palindrom to słowo które jest takie same od początku jak i od końca
 * np. kajak
 * Zrób program, który pobiera od użytkownika stringa i sprawdza zwraca czy jest palindromem.
 * Jeżeli użytkownik napisze: "ESC" to przechodzi dalej do następnych zadań.
 */

Console.WriteLine("Sprawdzajka do palindromów, podaj słowo");
while(true)
{
    var userInput = Console.ReadLine();
    if(userInput == "ESC")
    {
        break;
    }
    else
    {
        var size = userInput.Length;
        solvedTasks.IsPalindrome(userInput, true);
    }
}

//Rekurencja - Ciąg fibonacciego
/* Zad 1. Napisz funkcję liczącą kolejne liczby ciągu fibonacciego z wykorzystaniem rekurencji.
 * podpowiedź: ciąg fibonacciego to taka sekwencja:
 * 1 1 2 3 5 8 13 21 ...
 *el0 el1
 * każdy element ciągu fib można zapisać jako sumę dwóch poprzednich liczb:
 * 
 * n = n-1 + n-2
 */
//int res = solvedTasks.Fib2(50);
//System.Console.WriteLine(res);


solvedTasks.DisplayNthFibonacciNumber(10);

//Rekurencja - Inny przykład ciągu
/* Zad 2. Za pomocą rekurencji policz kolejne elementy ciągu opisanego daną funkcją:
 * 
 * an =         2   dla n = 1
 *      {  an-1 * 2 dla n nieparzystego
 *         an-1 + 2 dla n parzystego
 */

solvedTasks.DisplayCustomSeries(10);
//Powtórka z poprzednich zajęć tablice i proste algorytmy
/* Zad 3. Zadeklaruj tablicę 10 elementową i wypełnij ją liczbami (nie korzystaj z petli od 0 do size wpisz ręcznie numerki)
 * Następnie napisz funkcje: min i max, które kolejno zwracają minimalny element w tablicy i maksymalny element w tablicy.
 * funkcje zwracają int.
 * Na koniec wypisz wszystkie elementy tablicy, najmiejszy i największy element tablicy.
 */
int[] arr = new int[10] { 1, -8, 2, 7, -6, 5, 16, 4, -11, 18 };
solvedTasks.MinMaxArray(arr);

solvedTasks.Factorial(5);