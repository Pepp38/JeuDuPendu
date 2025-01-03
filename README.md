# Jeu Du Pendu

Un projet simple en C# pour perfectionner mes connaissances en programmation.

## 📚 Description

Ce projet implémente un jeu classique du pendu où l'utilisateur doit deviner les lettres d'un mot caché. Le programme utilise une boucle pour demander à l'utilisateur de deviner une lettre à la fois et affiche le mot partiellement dévoilé en fonction des lettres trouvées.

### Fonctionnalités actuelles :
- Affichage du mot avec les lettres trouvées et des underscores `_` pour les lettres non devinées.
- Validation des entrées utilisateur (seule une lettre est acceptée).
- Gestion de la casse (les lettres sont traitées comme insensibles à la casse).
- Affichage des messages indiquant si une lettre est correcte ou non.

---

## ⚙️ Installation

1. **Clonez le projet :**
   ```bash
   git clone https://github.com/Pepp38/JeuDuPendu.git
   cd JeuDuPendu
   ```

2. **Ouvrez le projet dans votre IDE préféré :**
   - Visual Studio
   - Visual Studio Code
   - Rider

3. **Exécutez le projet avec `dotnet`:**
   ```bash
   dotnet run
   ```

---

## 🔧 Structure du projet

- **Program.cs** : Contient la logique principale du jeu.
- **JeuDuPendu.sln** : Fichier solution pour Visual Studio.
- **bin/** et **obj/** : Dossiers générés par .NET lors de la compilation.

---

## 🕹️ Comment jouer ?

1. Lancez le jeu.
2. Un mot est défini dans le programme (actuellement, c'est **"bEleu"**).
3. Devinez une lettre en entrant une seule lettre à la fois.
4. Si la lettre est correcte, elle est dévoilée dans le mot. Sinon, un message indique qu'elle est incorrecte.
5. Continuez jusqu'à dévoiler tout le mot !

---

## 🚀 Améliorations prévues

- Ajouter un compteur de tentatives pour limiter les erreurs.
- Permettre la sélection aléatoire d'un mot parmi une liste.
- Implémenter une interface graphique ou un mode web.
- Ajouter des tests unitaires pour valider le fonctionnement des méthodes.

---

## 🛠️ Technologies utilisées

- **Langage** : C#
- **Framework** : .NET SDK
- **Outils** :
  - Visual Studio Code ou Visual Studio
  - Git pour le versionnement

---

## 💡 Objectif pédagogique

Ce projet m'aide à :
- Renforcer mes connaissances sur les structures de contrôle en C# (boucles, conditions).
- M'améliorer en gestion des collections comme les listes (`List<char>`).
- Apprendre à structurer un projet en C# et utiliser Git pour le suivi des versions.

---

## 📄 Licence

Ce projet est open-source et disponible sous [licence MIT](LICENSE).

---

## 🤝 Contributions

Les contributions, suggestions ou retours sont les bienvenus ! N'hésitez pas à ouvrir une issue ou soumettre une pull request.

---

### Auteur
**Pierre-Luc Carignan**
