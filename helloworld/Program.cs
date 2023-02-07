using System;

internal class Program
{
    private static void Main(string[] args)
    {
        
        // 1. Napisz program w C#, który stworzy dwie zmienne int i sprawdzi czy są one równe czy nie.
        int a = 26;
        int b = 5;
        if(a == b) 
        {
            Console.WriteLine(a + " i " + b + " są równe");
        }
        else 
        {
            Console.WriteLine(a + " i " + b + " nie są równe");
        }

        //2. Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba jest parzysta czy nieparzysta.

        int a = 10;
        if (a % 2 == 0)
        {
            Console.WriteLine(a + " jest liczbą parzystą");
        }
        else
        {
            Console.WriteLine(a + " jest liczbą nieparzystą");
        }

        //3. Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba jest dodatnia czy ujemna.

        int a = 0;
        if (a < 0)
        {
            Console.WriteLine(a + " jest liczbą ujemną");
        }
        else if (a > 0)
        {
            Console.WriteLine(a + " jest liczbą dodatnią");
        }
        else
        {
            Console.WriteLine(a + " nie jest ani liczbą dodatnią ani ujemną, jest zerem");
        }

        //4. Napisz program w C#, który sprawdzi czy podany przez użytkownika rok jest rokiem przestępnym.

        // Wersja 1

        Console.WriteLine("Podaj rok:");
        string inputYear = Console.ReadLine();
        int year = int.Parse(inputYear);

        if (year % 4 == 0)
        {
            if (year % 100 == 0)
            {
                if (year % 400 != 0)
                {
                    Console.WriteLine("Rok " + year + " nie jest przestępny.");
                }
                else
                {
                    Console.WriteLine("Rok " + year + " jest przestępny.");
                }
            }
            else
            {
                Console.WriteLine("Rok " + year + " jest przestępny.");
            }
        }
        else
        {
            Console.WriteLine("Rok " + year + " nie jest przestępny.");
        }

        // Wersja 2

        if ((year % 4 == 0 && year % 100 != 0) || (year % 4 == 0 && year % 100 == 0 && year % 400 == 0))
        {
            Console.WriteLine("Rok " + year + " jest przestępny.");
        }
        else
        {
            Console.WriteLine("Rok " + year + " nie jest przestępny.");
        }

        //5. Napisz program w C#, który sprawdzi czy podany przez użytkownika wiek uprawnia go do ubiegania się o stanowisko posła, premiera, sentarora,prezydenta.

        Console.WriteLine("Podaj swój wiek:");
        string inputage = Console.ReadLine();
        int age = int.Parse(inputage);
        if (age >= 35) 
        {
            Console.WriteLine("Masz " + age + ", możesz zatem zostać posłem, premierem, senatorem i prezydentem. Choć nie wszystkimi jednocześnie ;(");
        }
        else if(age >= 30)
        {
            Console.WriteLine("Masz " + age + ", możesz zatem zostać posłem, premierem i senatorem. Choć nie wszystkimi jednocześnie ;(");
        }
        else if(age>= 21) 
        {
            Console.WriteLine("Masz " + age + ", możesz zatem zostać posłem i premierem. I to jednocześnie :)");
        }
        else 
        {
            Console.WriteLine("Masz mniej niż 21 lat i musisz się jeszcze wstrzymać ze swoją publiczną służbą na najwyższych szczeblach państwowych ;(.");
        }

        //7. Napisz program w C#, który pobierze 3 liczby od użytkownika i sprawdzi, która jest największa


        Console.WriteLine("Podaj pierwszą liczbę:");
        string inputA = Console.ReadLine();
        int a = int.Parse(inputA);
        Console.WriteLine("Podaj drugą liczbę, różną od pierwszej:");
        string inputB = Console.ReadLine();
        int b = int.Parse(inputB);
        Console.WriteLine("Podaj trzecią liczbę, różną od poprzednich:");
        string inputC = Console.ReadLine();
        int c = int.Parse(inputC);

        if((a > b && a > c) || (a == b && a > c) || (a == c && a > b))
        {
            Console.WriteLine("Liczba " + a + " jest największa.");
        }
        else if (b > a && b > c)
        {
            Console.WriteLine("Liczba " + b + " jest największa.");
        }
        else if (c > a && c > b)
        {
            Console.WriteLine("Liczba " + c + " jest największa.");
        }
        
        else if (a == b && a == c)
        {
            Console.WriteLine("Wszystkie liczby są równe.");
        }
        else 
        {
            Console.WriteLine("Liczba " + b + " jest największa.");
        }

        /* Kod do wersji alternatywnej zad. 7
        else if (a == b && a > c)
        {
           Console.WriteLine("Liczba " + a + " jest największa."); 
        }
        else if (a == c && a > b)
        {
           Console.WriteLine("Liczba " + a + " jest największa."); 
        }*/

        
        //6. Napisz program w C#, który pobierze wzrost użytkownika i przypisze mu wymyśloną kategorię wzrostu.
        
       Console.WriteLine("Podaj swój wzrost w cm:");
        string inputToll = Console.ReadLine();
        int toll = int.Parse(inputToll);

        if (toll < 150)
        {
            Console.WriteLine("Jesteś krasnoludem.");
        }
        else if (toll < 185)
        {
            Console.WriteLine("Jesteś średniaczkiem.");
        }
        else if (toll < 200)
        {
            Console.WriteLine("Jesteś drągalem.");
        }
        else
        {
            Console.WriteLine("Jesteś gigantem.");
        }

        //8. Napisz program, który sprawdzi, czy kandydat może ubiegać się o miejsce na studiach

        Console.WriteLine("Wprowadź wynik z matematyki:");
        string inputMat = Console.ReadLine();
        int mat = int.Parse(inputMat);
        Console.WriteLine("Wprowadź wynik z fizyki:");
        string inputFiz = Console.ReadLine();
        int fiz = int.Parse(inputFiz);
        Console.WriteLine("Wprowadź wynik z chemii:");
        string inputChem = Console.ReadLine();
        int chem = int.Parse(inputChem);

        int sumMatFizChem = mat + fiz + chem;
        int sumMatFiz = mat + fiz;
        int sumMatChem = mat + chem;

        if((mat > 70 && fiz > 55 && chem > 45) || sumMatFizChem > 180 || sumMatFiz > 150 || sumMatChem > 150)
        {
            Console.WriteLine("Kandydat dopuszczony do rekrutacji.");
        }
        else
        {
            Console.WriteLine("Sorry, nie tym razem.");
        }

        //9. . Napisz program, który odczyta temperaturę I zwróci nazwę jak w poniższych kryteriach

        Console.WriteLine("Jaka jest dziś temperatura?");
        string inputCels = Console.ReadLine();
        int cels = int.Parse(inputCels);

        if(cels < 0 ) 
        {
            Console.WriteLine("cholernie piździ");
        }
        else if (cels < 10)
        {
            Console.WriteLine("zimno");
        }
        else if (cels < 20)
         {
            Console.WriteLine("chłodno");
        }
        else if (cels < 30)
        {
            Console.WriteLine("w sam raz");
        }
        else if (cels < 40)
        {
            Console.WriteLine("zaczyna być słabo, bo gorąco");
        }
        else
        {
            Console.WriteLine("a weź, wyprowadzam się na Alaskę");
        }

        //10. Napisz program, który sprawdzi, czy z 3 podanych długości można stworzyć trójkąt

        Console.WriteLine("Sprawdź, czy z odcinków o podanej długości, uda się zbudować trójkąt.\r\n");
        Console.WriteLine("Podaj pierwszą długość:");
        string inputA = Console.ReadLine();
        int a = int.Parse(inputA);
        Console.WriteLine("Podaj drugą długość:");
        string inputB = Console.ReadLine();
        int b = int.Parse(inputB);
        Console.WriteLine("Podaj trzecią długość:");
        string inputC = Console.ReadLine();
        int c = int.Parse(inputC);

        if(a + b > c && a + c > b && b +c > a) 
        {
            Console.WriteLine("Można zbudować trójkąt");
        }
        else
        {
            Console.WriteLine("Nic z tego!");
        }

        //11. Napisz program, który zmieni ocenę ucznia na jej opis wg podanej tabeli
        // Wersja 1

        Console.WriteLine("Wprowadź ocenę z zakresu od 1 do 6:");
        string inputGrade = Console.ReadLine();
        int grade = int.Parse(inputGrade);

        switch(grade) 
        {
            case 1:
                Console.WriteLine("Niedostateczny");
                break;  
            case 2:
                Console.WriteLine("Dopuszczający");
                break;
            case 3:
                Console.WriteLine("Dostateczny");
                break;
            case 4:
                Console.WriteLine("Dobry");
                break;
            case 5:            
                Console.WriteLine("Bardzo dobry");
                break;
            case 6:
                Console.WriteLine("Celujący");
                break;
            default: 
                Console.WriteLine("Wprowadzono nieprawidłowe dane. Dopuszczalne wyłącznie liczby z zakresu 1 - 6.");
                break;
        }

        //Wersja 2

        Console.WriteLine("Wprowadź ocenę z zakresu od 1 do 6:");
        string inputGrade = Console.ReadLine();
        int grade = int.Parse(inputGrade);

        string descript = grade switch
        {
            1 => "Niedostateczny",
            2 => "Dopuszczający",
            3 => "Dostateczny",
            4 => "Dobry",
            5 => "Bardzo dobry",
            6 => "Celujący",
            _ => "Wprowadzono nieprawidłowe dane. Dopuszczalne wyłącznie liczby z zakresu 1 - 6.",
        };
        Console.WriteLine(descript);

        //12. Napisz program, który pobierze numer dnia tygodnia i wyświetli jego nazwę

        Console.WriteLine("Wprowadź numer dnia z zakresu od 1 do 7:");
        string inputNumDay = Console.ReadLine();
        int numDay = int.Parse(inputNumDay);

        string day = numDay switch
        {
             1 => "poniedziałek",
             2 => "wtorek",
             3 => "środa",
             4 => "czwartek",
             5 => "piątek",
             6 => "sobota",
             7 => "niedziela",
             _ => "Wprowadzono nieprawidłowe dane. Dopuszczalne wyłącznie liczby z zakresu 1 - 7.",
        };
        Console.WriteLine(day);

        //13. Napisz program, który będzie posiadał proste menu (wg. Wzoru poniżej) I będzie prostym kalkulatorem

        Console.WriteLine("Podaj pierwszą liczbę:");
        string inputA = Console.ReadLine();
        double a; 
        double.TryParse(inputA, out a);
        Console.WriteLine("Podaj drugą liczbę:");
        string inputB = Console.ReadLine();
        double b; 
        double.TryParse(inputB, out b);
        Console.WriteLine("Podaj numer operacji do wykonania: \r\n1. Dodawanie \r\n2. Odejmowanie \r\n3. Mnożenie \r\n4. Dzielenie");
        string inputNum = Console.ReadLine();
        int num = int.Parse(inputNum);

        if(num == 4 && b == 0) 
        {
            Console.WriteLine("Pamietaj cholero, nie dziel przez zero!");
        }
        else
        {
            double result = num switch
            {
                1 => a + b,
                2 => a - b,
                3 => a * b,
                4 => a / b,
            };
            Console.WriteLine(result);
        }

        

        // Z poprzednich zadań do ewentualnego ponownego użycia :)    
        /*Console.WriteLine("Imię:");
        string name = Console.ReadLine();
        Console.WriteLine("Nazwisko:");
        string surname = Console.ReadLine();
        Console.WriteLine("Wiek:");
        string inputAge = Console.ReadLine();
        int age = int.Parse(inputAge);
        Console.WriteLine("Płeć:");
        string inputSex = Console.ReadLine();
        char sex = inputSex[0];
        Console.WriteLine("PESEL:");
        string pesel = Console.ReadLine();
        Console.WriteLine("Numer pracownika");
        string inputEmployeeNumber = Console.ReadLine();
        int employeeNumber = int.Parse(inputEmployeeNumber);
        Console.WriteLine($" \r\n");
        Console.WriteLine($"Imię: {name}");
        Console.WriteLine($"Nazwisko: {surname}");
        Console.WriteLine($"Wiek: {age}");
        Console.WriteLine($"Płeć: {sex}");
        Console.WriteLine($"PESEL: {pesel}");
        Console.WriteLine($"Numer pracownika: {employeeNumber}");
        Console.Write($"\r\nImię: {name} \r\nNazwisko: {surname}\r\n\r\n");

        poniżej poprawne użycie wyrażenia warunkowego ternary - muszą być zwracane wartości, a metoda WriteLine zwraca void - 
        czyli brak wartości
        string wynik = a == b ? "Te liczby są równe" : "Te liczby nie są równe";
        Console.WriteLine(wynik);
        
        char one = 'a';
        char two = 'b';
        char three = 'c';
        Console.WriteLine("" + three + two + one);
      

        Console.WriteLine("Długość boku a:");
        string inputSideA = Console.ReadLine();
        double SideA = double.Parse(inputSideA);

        Console.WriteLine("Długość boku b:");
        string inputSideB = Console.ReadLine();
        double SideB = double.Parse(inputSideB);

        double diagonal = Math.Sqrt(Math.Pow(SideA, 2) + Math.Pow(SideB, 2));
        Console.WriteLine("Długość przekątnej:" + diagonal);*/
    }
}
