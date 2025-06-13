# Instrukcja obsługi:
## Baza danych:
Aby szybko podłączyć przykładową baze danych, to można skorzystać z plików backup-owych bazy które znajdują się w: SerwisTelefonow/Data/ (baza danych z postgresql)
- service_db_backup.sql - baza danych utworzona przy pomocy migracji, jest w formacie plain (zwykłym sql)
- service_db_backup_raw.sql - ta sama baza co powyżej ale w formacie bitowym - odpowiednia dla aplikacji pgadmin4 v8.8 oraz postgres 17
- service_db_backup2.sql - analogicznie do poprzednich, ale były na niej przeprowadzane testy aplikacji
- service_db_backup_raw2.sql

## Połączenie z bazą danych:
  Konfigurację połączenia można znaleźć i edytować w SerwisTelefonow/ appsettings.json
 <br> Poniżej przedstawiono przykładowe dane:
- Host=localhost;
- Port=5434;
- Database=SerwisTelefonow;
- Username=postgres;
- Password=123

<br><br>
Aplikacja jest na .NET 8.0
<br>

## Używanie aplikacji:
# Strona startowa:
- Na stronie startowej użytkownik (klient serwisu) może sprawdzić postęp naprawy: ukończone lub nie.
  Aby to zrobić musi podać kod, który pownien być mu wręczony na wydrukowanej karcie serwisowej.

- Pomijamy panel logowania i authentykacji, więc przechodzimy do panelu serwisanta:

![Untitled](https://github.com/user-attachments/assets/c51d1029-3e45-49d7-9c87-fedab314cbc6)

- Wtedy możemy ujżeć główną stronę formularza serwisowego:
![image](https://github.com/user-attachments/assets/b8da8f64-cf21-4c2f-b42b-89ada2c20176)
- Na niej mamy możliwość wybrania z tabel wpisów które nas interesują, które zostaną wprowadzone automatycznie po naciśnięciu na któregoś z nich.
- Jeżeli nie ma pożądanego wpisu modelu, możemy go dodać.
- Po dodaniu wpisu serwisowego otrzymamy kod, po którym możemy wyświetlić dany wpis naprawy serwisowej.
Kod ten wygląda następująco: [XXX - salt] [YYY - service_entr_id] [XX - salt] [YYY - client_id] [X - salt]
Składa się z identyfikatorów zapisanych w bazie danych wraz z losowymi literami lub cyframi, np. JM8001QF003B -    JM8 - 001 - QF - 003 - B
![image](https://github.com/user-attachments/assets/ecb5b4b9-4c90-46f1-af6b-e8d2f0b9d7ee)

- Po kliknięciu w opcję w menu: Serwisy -> Przegladaj wpisy:
![image](https://github.com/user-attachments/assets/0e08d17c-2f22-460f-8729-9e80026dcdeb)
- Mamy możliwość:
  -  przeglądania rekordów w bazie danych,
  -  edycję poprzez bezpośrednie edytowanie danych w tabeli oraz zapisanie ich - odpowiednim przyciskiem,
  -  usuwania danych poprzez zaznaczenie danego wiersza oraz kliknięcie przycisku "Usuń wpis",
  -  wyszukanie danego wpisu serwisowego odpowiadającemu odpowiedniemu kodowi,
  -  analogicznie odwrotna operacja jest możliwa - po wybranym rekordzie utworzyć kod
  -  odświerzenie załadowanych danych do tabel.
- Po przejściu na Serwisy -> "Wydruk zgłoszenie":
![image](https://github.com/user-attachments/assets/30c7afef-39b3-460a-8660-0535423ad7e0)
  - Możemy wybrać którego wpisu serwisowego chcemy wygenerować kartę serwisową (z aktualną lokalną datą)
  - Mamy możliwość zapisać albo wydrukować dany plik formatu pdf. (Jeden jest dla serwisanta a inny dla klienta (na co wskazuje przerywana linia)).
  Służy on jako dowód na oddanie telefonu serwisowi na czas naprawy.
 


