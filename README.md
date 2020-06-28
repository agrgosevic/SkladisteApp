# Aplikacija za vođenje statistike skladišta i planiranje zaliha
Aplikacija služi za vođenje statistike skladišta i planiranja zalihama koje su na skladištu. Za upravljanje zalihama korištena je FIFO (engl. First-In, First-Out) strategija. Korištenjem ove strategije potrebno je prvo prodati one artikle/proizvode koji su prvi ušli na skladište. Aplikacija je izrađena u C# (Visual Studio 2019) te je popraćena s PostgreSQL bazom podataka u alatu pgAdmin 4.

## Instalacija
Kako bi se aplikacija i baza podataka instalirale potrebno je napraviti sljedeće:
* Preko setup datoteke (*SkladisteApp*) instalirati aplikaciju na željeno mjesto
* Na lokalnom serveru od izabrane postgres baze podataka (preporučeno je koristiti pgAdmin 4) kreirati korisnika admin s lozinkom  admin i postaviti ga na superuser, odnosno dati mu sva dopuštenja
* U nekoj od postgres baza podataka kreirati bazu podataka s imenom TBP Baza
* Otvoriti datoteku *SkladisteBackUp.sql* te kopirati njezin sadržaj u prozoru za izvršavanje SQl upita
