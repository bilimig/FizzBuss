## FizzBuzz Program

### Opis
Program FizzBuzz to prosta aplikacja konsolowa napisana w języku C#, która przyjmuje od użytkownika liczbę całkowitą i wyświetla serię liczb od 1 do tej liczby. Jeśli liczba jest podzielna przez 3, program wypisuje "Fizz", jeśli przez 5, wypisuje "Buzz", a jeśli przez obie te liczby, wypisuje "FizzBuzz".

### Instrukcje
1. Program wyświetla komunikat "Podaj liczbe:", po czym oczekuje na wprowadzenie liczby przez użytkownika.
2. Po wprowadzeniu liczby, ekran jest czyszczony, a następnie program wyświetla serię liczb od 1 do wprowadzonej liczby, stosując zasady FizzBuzz.
3. Jeśli liczba jest podzielna przez 3, program wypisuje "Fizz".
4. Jeśli liczba jest podzielna przez 5, program wypisuje "Buzz".
5. Jeśli liczba jest podzielna zarówno przez 3, jak i przez 5, program wypisuje "FizzBuzz".
6. W przeciwnym razie program wypisuje samą liczbę.

### Struktura Kodu
- Klasa `FizzBuzz` zawiera logikę programu, w tym metodę `FizzBuzzing()`, która realizuje działanie FizzBuzz, oraz prywatne metody `mod3()` i `mod5()` sprawdzające, czy liczba jest podzielna przez 3 lub 5.
- Prywatne metody `mod3()` i `mod5()` zwracają `true`, jeśli liczba jest podzielna przez 3 lub 5, w przeciwnym razie zwracają `false`.

### Wymagania
- Aplikacja wymaga środowiska uruchomieniowego języka C#.

### Uruchomienie
1. Skompiluj program za pomocą kompilatora C#.
2. Uruchom skompilowany plik wykonywalny.
3. Postępuj zgodnie z instrukcjami wyświetlanymi na ekranie.
