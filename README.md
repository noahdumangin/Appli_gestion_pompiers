# Application de gestion des pompiers

Ce projet propose une application de **gestion des missions et des interventions des pompiers**, développée en **C# sous Visual Studio**.  
L’application permet de gérer les utilisateurs, d’assurer la connexion des agents, et d’administrer les missions via une interface graphique intuitive connectée à une base de données SQLite.


## Table des matières
- [Structure du projet](#structure-du-projet)  
- [Fonctionnement](#fonctionnement)  
- [Base de données](#base-de-données)
- [Collabortaion](#collaboration)
- [Images](#images)
  

## Structure du projet

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
  
  ![pdf](Images/pdf.png)
  <p>Possibilité de générer un pdf pour les missions</p>
  <br><br><br>
  
  ![creation_missions](Images/creation_mission.png)
  <p>Création de missions par les opérateurs des pompiers</p>
  <br><br><br>

  ![creation_missions](Images/loading.png)
  <p>Fenêtre de chargement pour la création d'une mission</p>
  <br><br><br>

  ![creation_missions](Images/engins.png)
  <p>Fenêtre de visionnage des engins </p>
  <br><br><br>

  ![creation_missions](Images/gestion_pompiers.png)
  <p>Fenêtre de visionnage des pompiers avec possibilité de modifications</p>
  <br><br><br>

  ![creation_missions](Images/login.png)
  <p>Possibilité de modification des pompiers avec identification de l'administrateur</p>
  <br><br><br>

  ![creation_missions](Images/statistiques.png)
  <p>Statistiques des casernes/missions/engins</p>
  <br><br><br>
