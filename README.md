# 🎮 Jeu du Pendu

## 📝 Description
Le **Jeu du Pendu** est une application console amusante en C# où vous devez deviner un mot lettre par lettre. Attention, chaque erreur vous rapproche du pendu !

## 🚀 Fonctionnalités
- 🎲 Choix aléatoire d'un mot parmi une liste de plus de 850 mots.
- ⌨️ Saisie interactive pour deviner les lettres.
- 🖼️ Affichage graphique du pendu à chaque étape.
- ❤️ 6 vies pour tenter de deviner le mot avant de perdre.
- 🔁 Option de rejouer autant de fois que vous le souhaitez.

## 📂 Fichiers du projet
- `Ascii.cs` : Gère l'affichage graphique du pendu.
- `Program.cs` : Contient la logique principale du jeu.
- `mots.txt` : Liste des mots utilisés dans le jeu (plus de 850 mots).
- `JeuDuPendu.csproj` : Fichier de configuration du projet.
- `bin` et `obj` : Répertoires pour les fichiers compilés et temporaires.

## 🛠️ Installation
1. Clonez ou téléchargez ce dépôt.
2. Ouvrez un terminal dans le dossier du projet.
3. Compilez le projet avec la commande :
   ```bash
   dotnet build
   ```

## ▶️ Utilisation
1. Lancez le jeu avec :
   ```bash
   dotnet run
   ```
2. Suivez les instructions :
   - Entrez une lettre pour essayer de deviner le mot.
   - Tapez "quit" pour quitter la partie.
   - Répondez par "O" ou "N" pour rejouer après chaque partie.
3. Amusez-vous et essayez de ne pas vous faire pendre !

## 🔧 Comment ça fonctionne ?
- **Main** : Gère le déroulement principal du jeu.
- **ChargerMot** : Choisit un mot aléatoire dans `mots.txt`.
- **DevinerMot** : Logique principale du jeu, gère les vies et les lettres devinées.
- **AfficherEtat** : Montre l'état actuel du pendu, du mot et des lettres essayées.
- **DemanderLettre** : Valide et retourne une lettre saisie par l'utilisateur.
- **AfficherMot** : Affiche le mot avec les lettres correctement devinées.

## 🌟 Idées d'amélioration
- Ajouter un mode facile/difficile.
- Augmenter les animations visuelles du pendu.
- Intégrer une interface graphique (par exemple avec WPF).

## 📬 Contribuez
Envie d'ajouter vos propres idées ? Forkez ce dépôt et soumettez vos modifications !

## © Auteur
Ce projet a été créé pour s'amuser et apprendre. Améliorez-le à votre guise !

## 📜 Licence
Projet sous licence MIT. Utilisation libre pour tous.

