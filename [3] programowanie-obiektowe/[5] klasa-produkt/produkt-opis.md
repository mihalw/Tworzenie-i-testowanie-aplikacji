Napisz program, który tworzy klasę Produkt zawierającą:
- prywatne pole nazwa typu napisowego
- prywatne pole cena typu zmiennoprzecinkowego
- prywatne pole kategoria typu napisowego
- prywatne pole stan typu napisowego ("dostępny" lub "niedostępny")
- ogólnodostępny konstruktor 4-argumentowy przyjmujący pola nazwa, cena, kategoria, stan i ustawiający pola w klasie równe wartościom parametrów 
- ogólnodostępną metodę WyswietlInformacje, która nie przyjmuje parametrów i wyświetla wszystkie informacje na temat produktu, metoda nie zwraca żadnej wartości
- ogólnodostępną metodę ObnizCene, która przyjmuje argument typu całkowitoliczbowego i która obniża cenę o tyle procent o ile wskazano w parametrze, metoda nie zwraca wartości
- ogólnodostępną metodę Sprzedaj, która nie przyjmuje żadnego parametru i zmienia stan produktu na "niedostępny" jeśli dotychczas to pole miało wartość "dostępny", w innym przypadku metoda informuje, że produkt jest niedostępny i nie można go kupić, metoda nie zwraca wartości
 
Wewnątrz metody Main:
- stwórz obiekt za pomocą konstruktora czteroargumentowego ("Laptop", 4800, "Laptopy i komputery", "dostępny")
- wywołaj metodę WyswietlInformacje dla obiektu
- wywołaj metodę ObnizCene z argumentem 20, aby obniżyć cenę produktu
- wywołaj metodę WyswietlInformacje dla obiektu 

- stwórz drugi obiekt za pomocą konstruktora czteroargumentowego ("Pralka", 2500, "AGD", "dostępny")
- wywołaj metodę Sprzedaj dla drugiego obiektu
- wywołaj metodę WyswietlInformacje dla drugiego obiektu
- ponownie wywołaj metodę Sprzedaj dla drugiego obiektu
   
