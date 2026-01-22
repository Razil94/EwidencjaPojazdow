# 🚗 Ewidencja pojazdów

Projekt zaliczeniowy realizujący aplikację w dwóch technologiach: desktopowej (Windows Forms) oraz webowej (HTML/Bootstrap/JS).

## 📸 Podgląd aplikacji

### Wersja Webowa (Etap 3 i 4)
Strona internetowa z responsywnym interfejsem Bootstrap, obsługą modali i dynamiczną tabelą JS.
<img width="1846" height="727" alt="web 1" src="https://github.com/user-attachments/assets/a6ba1148-71fd-442a-9a64-dfff84ca7c4e" />
<img width="1829" height="784" alt="web 2" src="https://github.com/user-attachments/assets/d6fe0d92-0747-4905-8fc0-3d1f9d8e67e4" />



### Wersja desktopowa (Etap 1 i 2)
Aplikacja okienkowa z bazą lokalną, systemem raportowania RDLC i eksportem do PDF.
<img width="831" height="660" alt="Desktop 1" src="https://github.com/user-attachments/assets/176ef19b-016f-463f-b249-c20591c4c766" />
<img width="893" height="509" alt="Desktop 2" src="https://github.com/user-attachments/assets/62d1798b-92ac-4f7d-ae82-68c6b7d729dd" />
<img width="1912" height="580" alt="Desktop 3" src="https://github.com/user-attachments/assets/de09fa06-9d60-4518-8243-18eb12dd7dba" />
<img width="774" height="72" alt="Dektop 4" src="https://github.com/user-attachments/assets/0f24195e-a450-46fb-98c1-61db14e522e8" />





---

## 📝 Opis projektu

Projekt został zrealizowany w czterech etapach, pokrywając pełen zakres wymagań: od formularzy okienkowych po interaktywną stronę www.

### ✅ Zakres funkcjonalności:

#### 🖥️ Część desktopowa (.NET WinForms)
* **Formularz ewidencji:** Dodawanie pojazdów (Nr rejestracyjny, Marka, Model, Rok, Data przeglądu).
* **Raportowanie:** Generowanie raportu "Pojazdy z przeglądem w bieżącym miesiącu" przy użyciu **ReportViewer**.
* **Eksport danych:** Możliwość zapisu wygenerowanego raportu bezpośrednio do pliku **PDF**.
* **Logika biznesowa:** Filtrowanie danych przy użyciu LINQ.

#### 🌐 Część webowa (HTML5 + Bootstrap 5)
* **Nowoczesny UI:** Responsywna tabela i formularze stylowane biblioteką **Bootstrap 5**.
* **CRUD Frontend:** Dynamiczne dodawanie i usuwanie wierszy z tabeli przy użyciu **JavaScript**.
* **Walidacja:** Zabezpieczenie przed wprowadzaniem błędnych danych (np. rok spoza zakresu, puste pola).
* **Interaktywność:** Formularz dodawania pojazdu umieszczony w oknie modalnym (pop-up).

---

## 🛠️ Użyte technologie

* **Języki:** C#, JavaScript, HTML5, CSS3
* **Frameworki/Biblioteki:** .NET Framework (WinForms), Bootstrap 5
* **Narzędzia:** Visual Studio 2022, Visual Studio Code, Git & GitHub
* **Raportowanie:** Microsoft RDLC Report Designer, ReportViewer

---

## 🚀 Jak uruchomić projekt

### Aplikacja Desktopowa
1.  Pobierz repozytorium.
2.  Otwórz plik `EwidencjaPojazdow.sln` w Visual Studio.
3.  Uruchom projekt przyciskiem **Start**.

### Aplikacja Webowa
1.  Wejdź do folderu `Web`.
2.  Otwórz plik `index.html` w dowolnej przeglądarce internetowej.

---

*Projekt wykonany w ramach zaliczenia przedmiotu: Projektowanie interfejsów użytkownika .*
