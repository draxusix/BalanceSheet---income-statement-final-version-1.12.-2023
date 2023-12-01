# BalanceSheet---income-statement---final-version-1.12.-2023

Název Projektu: BalanceSheet - Rozvaha

Popis Projektu:
BalanceSheet - Rozvaha je aplikace, která umožňuje přepočet hodnot z CZK do EUR pro položky výkazu. Program vypisuje hodnoty jednotlivých položek a výsledný součet do konzole. Tento nástroj je ideální pro účetní a finanční analytiky, kteří potřebují rychle převést hodnoty v rozvaze z korun na eura.

Požadavky:
Základní knihovny .NET

Instalace:
Jelikož se jedná o jednoduchou konzolovou aplikaci, není potřeba žádná speciální instalace. Stačí mít nainstalováno .NET prostředí.

Použití:
Spusťte aplikaci, a na konzoli uvidíte výpis položek rozvahy a výsledné součty.
Aplikace používá pro přepočty kurz z posledního čtvrtletí roku 2023 a aktuální kurz pro dané datum.

Vylepšení:
Možná vylepšení zahrnují implementaci dynamického přidávání/odebírání položek a integraci API pro získávání aktuálních kurzů nebo například grafické zpracování ve WindowsForms.

Licence:
Tento projekt je volně dostupný a nepodléhá žádné specifické licenci.

Autoři a Poděkování:
Tento projekt byl vytvořen s důrazem na pochopení a aplikaci různých kurzovních přepočtů pro specifické účetní položky. Díky zkušenostem získaným při řešení tohoto úkolu jsem se naučil, jaké kurzy se používají pro specifické položky a proč. Návrhový vzor Strategy byl použit pro definování přepočtů pro jednotlivé položky. Speciální poděkování patří všem, kdo se podíleli na shromažďování a analýze dat potřebných pro tento projekt.

Závěr:
Při zpracování zadání jsem měl z počátku problém zjistit a pochopit, co se myslí jednotlivými algoritmy kurzovního přepočtu. Nakonec jsem zjistil, jaké kurzy se využívají pro specifické položky a také proč - Na základě toho jsem pro Asset použil historický kurz z posledního čtvrtletí roku 2023, konkrétně z 10.11. a pro další položky kurz aktuální  - Vyjma položky PL, vysvětlení je obsaženo v komentářích uvnitř kódu. Zadání obsahovalo výsledkovou rozvahu pro poslední čtvrtletí roku 2023, nicméně kurz pro datum 31.12. 2023 jsem nemohl zjistit, proto jsem použil aktuální kurz ze dne 30.11. 2023. Všechny kurzy byly získány z oficiálních stránek ČNB. Jako návrhový vzor jsem si zvolil Strategy a využil jej pro definování přepočtů pro jednotlivé položky. 
