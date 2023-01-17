# SalesInvoice PL



## Wymagane oprogramowanie do uruchomienia aplikacji
Minimalne wymagania systemowe:
- system Windows (Xp+) lub inny system wspierający poniższe biblioteki i binaria,
- .Net Framework 4.6+,
- SQL Server (R) Compact Edition 4.0+ [Download](https://www.microsoft.com/en-us/download/details.aspx?id=30709)

## PL - Wymagane pakiety NuGet
Do poprawnej kompilacji aplikacji wymagane są następujące pakiety:
- https://www.nuget.org/packages/FreeSpire.PDF/,
- https://www.nuget.org/packages/EntityFramework/

## Kompilacja
~~Aby skompilować aplikację na swojej maszynie i korzystać z jej całej funkcjonalności należy uzupełnić klucz API w pliku 
[DownloadDataFromCEIDG.vb](https://github.com/Aveneid/SalesInvoiceFinal/blob/master/Client/DownloadDataFromCEIDG.vb#L20), klucz jest możliwy do uzyskania po [rejestacji](https://datastore.ceidg.gov.pl/) i jego 
[wygenerowaniu](https://datastore.ceidg.gov.pl/CEIDG.DataStore/CEIDG.Public.UI/User/UserEdit.aspx), dokumentacja API dostępna jest [tutaj](https://datastore.ceidg.gov.pl/CEIDG.DataStore/Styles/Regulations/API_Datastore_20190314.pdf).~~  
Od lipca 2019 roku powyższy sposób pobierania danych o podmiotach nie jest możliwy.

## Rozwijanie aplikacji
Każda osoba zainteresowana może rozwijać, zmieniać i edytować aplikację pod swoje indywidualne potrzeby, zachowując przy tym warunki licencji.
Wszystkie błędy oraz propozycje należy zgłaszać przez Issue tracker.

## Licencja
GNU GPL

# SalesInvoice EN

## Required software
Minimal system requirements:
- Windows system (Xp+) or any operating system that can run and support libraries listed below,
- .NET Framework 4.6
- SQL Server (R) Compact Edition 4.0+  Download](https://www.microsoft.com/en-us/download/details.aspx?id=30709)

## NuGet Packages
- https://www.nuget.org/packages/FreeSpire.PDF/,
- https://www.nuget.org/packages/EntityFramework/

## Compilation
~~To properly compile applicaiton and use it full features you have to type in yout API key into [DownloadDataFromCEIDG.vb](https://github.com/Aveneid/SalesInvoiceFinal/blob/master/Client/DownloadDataFromCEIDG.vb#L20),
key can be obtained via [registration](https://datastore.ceidg.gov.pl/) and [key generation](https://datastore.ceidg.gov.pl/CEIDG.DataStore/CEIDG.Public.UI/User/UserEdit.aspx). API documentation can be found [here](https://datastore.ceidg.gov.pl/CEIDG.DataStore/Styles/Regulations/API_Datastore_20190314.pdf).~~
By july 2019 this method of gathering company information is not possible.

## Future of SalesInvoice
Everyone intrested in this application can bring his own features and improvements and make use of them for individual use, remembering to keep license.
All issues, features and so on have to be reported via Issue tracker.

## License 
GNU GPL
