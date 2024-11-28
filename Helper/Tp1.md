Dans son unity:

- scene
- game
  fenetre d'exécution
- hierachy
  container de l'element de la scene
- projet
  contient tout le contenu du projet
- inspector
  les parametres de l'object choisi

Unity - moteur de jeu 3D

un component c'est un composant que l'on applique a un objet pour lui donner une fonction precise

## LyfeCycle

awake : au demarage, avant le start, une seule fois

onEnable: quand l'objet est activé, avant le start, une seule fois

Start: au demarage, une seule fois

fixedUpdate: a chaque frame, mais a intervalle regulier, pour les loi de la physique

Update: a chaque frame

LateUpdate: a chaque frame, mais apres tout les update

onDisable: quand l'objet est desactivé, une seule fois

onDestroy: quand l'objet est detruit, une seule fois

## Manager

attention le "find" est couteux en ressource et aussi en temps, par ailleurs le nom de l'objet doit etre exacte et dans la scene il peut y avoir plusieurs objet avec le meme nom

## Coroutine

private IEnumerator
Voir la documentation