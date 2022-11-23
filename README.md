Hoe je het programma werkend krijgt

1. Installeer MS sql server studio management. ( log in met windows authentications, niet sql server auth)
2. importeer de bijgeleverde sql file
--> klaar met ms sql server studio management

- x - x - x - x - x - x - x - x - x - x - x - x

Connectie maken met sql server studio

!! MS sql server studio moet draaiende zijn voordat onderstaande stappen succesvol afgerond kunnen worden!!

1. open de tab "server explorer" (dit kan onder het kopje "View" gevonden worden)
2. klik met de rechtermuis knop op Data Connections en kies "add Connection..."
3. Server name = de naam van de lokale server, oftewel wat net opgezet is in MS sql server
--> authentication = windows authentication
4 Nadat een naam ingevoerd is kun je een keuze maken onder het kopje : "Connect to a database"
--> wanneer MS sql server goed is opgezet en de DB is geimporteerd, komt de rayco DB als een keuze naar voren. 
5. Klik op OK wanneer bovenstaande stappen gedaan zijn, nu is er een connectie gemaakt met MS sql server studio 

- x - x - x - x - x - x - x - x - x - x - x - x

1. In de code van het project verander de "SqlConnection conn" string variable om connectie met de database op die pagina de activeren
--> source = de naam van de connectie (dus van sql server) en catalog moet overeen komen met de naam van de DB.
2. HR.py (oftewel) de local server moet draaiend zijn.
--> draai dit programma via de terminal of andere manier wat voor jou handig is
3. De meegeleverde database heeft users (die zijn niet hetzelfde als die van de HR-tool!)
--> a. met account: jasper , password: test . Kun je inloggen met een "admin" level account
    b. met account: mariyana , password: 12345 . Kun je inloggen met een "project member" level account 
4. De meegeleverde DB heeft al data voor projecten/taken/gebruikers etc, maar kan ook leeg gebruikt worden mits er een "user" is om in te loggen!

Dit zijn alle benodigde stappen om de software lokaal in gebruik te nemen.
