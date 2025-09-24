# Branching strategie
### main:
Hier komt de uiteindelijke code te staan.
Het is niet de bedoeling dat hier directe commits features of fixes naar gedaan worden.

### develop:
Hier worden alle features eerst verzameld en samen getest, dan pas kan er met main gemergd worden.

### feature:
Op de feature branches worden de features ontwikkeld en getest, daarna kan er gemergd worden met develop.
De naam van een features branch is altijd als volgt: feature/naam_van_feature

### hotfix:
Op de hotfix branches worden hotfixes gemaakt voor de main branch. Deze kunnen na het testen met main gemergd worden.



# GroceryApp sprint3 Studentversie  
    
## UC07 Delen boodschappenlijst  
Is compleet  
  
## UC08 Zoeken producten  
Aanvullen:
- In de GroceryListItemsView zitten twee Collection Views, namelijk één voor de inhoud van de boodschappenlijst en één voor producten die je toe kunt voegen aan de boodschappenlijst  
- Voeg boven de tweede CollectionView een zoekveld (SearchBar) in om op producten te kunnen zoeken.  
- Zorg dat de SearchCommand wordt gebonden aan een functie in het onderliggende ViewModel (GroceryListItemsViewModel) en dat de zoekterm die in het zoekveld is ingetypt gebruikt wordt als parameter (SearchCommandParameter).  
- Werk in het viewModel (GroceryListItemsViewModel) de zoekfunctie uit en zorg dat de beschikbare producten worden gefilterd op de zoekterm!  

## UCx Registratie gebruiker 
Of een ander idee zelf uitwerken. Dit betekent ook dat de documentatie hiervoor ontwikkeld moet worden.

  

