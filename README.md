# Application de gestion des pompiers

Ce projet propose une application de **gestion des missions et des interventions des pompiers**, développée en **C# sous Visual Studio**.  
L’application permet de gérer les utilisateurs, d’assurer la connexion des agents, et d’administrer les missions via une interface graphique intuitive connectée à une base de données SQLite.


## Table des matières
- [Structure du projet](#structure-du-projet)  
- [Fonctionnement](#fonctionnement)  
- [Base de données](#base-de-données)
- [Collabortaion](#collaboration)
- [Images](#Images)
  

## Structure du projet

### Fichiers et dossiers principaux
- `UserControlMission/` : Contient les contrôles utilisateurs (interfaces, formulaires, logique).  
- `UserControlMission.sln` / `UserControlMission.csproj` : Solution et projet Visual Studio.  
- `Connexion.cs` : Gestion de la connexion et authentification des utilisateurs.  
- `UserControl1.cs`, `UserControl1.Designer.cs`, `UserControl1.resx` : Contrôle principal affichant les missions.  
- `app.config` : Fichier de configuration .NET (chaînes de connexion et paramètres).  
- `packages.config` : Dépendances NuGet.  
- `SDIS67.db` : Base de données SQLite utilisée par l’application.  

## Fonctionnement

1. **Interface principale**
   L’utilisateur accède à l’interface affichant la liste des missions, leur statut, les détails et les affectations.
   
2. **Gestion des missions**  
   L’utilisateur peut **créer**, **modifier**, **supprimer** (selon les droits) et **consulter** les missions. Les actions sont persistées dans la base SQLite.
   
3. **Gestion des pompiers**
   L'utilisateur peut consulter la base de données pour voir les pompiers avec toutes leurs informations. Il peut aussi modifier ces informations en s'identifiant en tant qu'administrateur. 
   
4. **Statistique**
   L'onglet permet de voir certaines statistiques en choisissant parmi les contraintes existantes.
   
5. **Gestion des engins**
  Permet d'afficher les engins.



## Base de données

Le fichier `SDIS67.db` contient les tables principales attendues par l’application (noms et colonnes peuvent varier) :

- `Pompiers` — Informations des agents (id, nom, prénom, grade, login, mot_de_passe, etc.).  
- `Missions` — Détails des interventions (id, type, date, localisation, statut, description).  
- `Vehicules` *(si présent)* — Informations des véhicules (id, immatriculation, type).  
- `Affectations` *(si présent)* — Liaison entre pompiers et missions.

> Pour inspecter la base : utiliser un navigateur SQLite (DB Browser for SQLite) ou exécuter des requêtes depuis Visual Studio.

  ## Collaboration

  Réalisation de ce projet avec 2 étudiants.

  ## Images

  Pour illustrer la présentation voilà des captures d'écrans de l'application : 
  
  ![affichage des règles du jeu](Images/tableau_de_bord.png)
  <br>
  <p>Tableau de bord avec affichage des missions</p>
  <br><br><br>
  
  ![affichage des résultats globalement](Images/VueGlobale.png)
  <p>Fenêtre d'affichage des résultats global</p>
  <br><br><br>
  
  ![affichage des résultats tour par tour](Images/Vuetour.png)
  <p>Fenêtre d'affichage des résultats tour par tour</p>
  <br><br><br>
