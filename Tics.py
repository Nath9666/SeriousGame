import json
import keyboard

# Chemin vers le fichier JSON
json_file_path = './Tics.json'

# Charger les données JSON
with open(json_file_path, 'r') as file:
    data = json.load(file)

# Dictionnaire pour mapper les premières lettres aux clés JSON
key_mapping = {
    'p': 'par exemple',
    'j': 'jeux serieux',
    'e': 'en general',
    'd': 'donc',
    'v': 'vous suivez',
    't': 'tout le monde',
}

# Fonction pour mettre à jour le fichier JSON
def update_json(key):
    if key in key_mapping:
        data[key_mapping[key]] = str(int(data[key_mapping[key]]) + 1)
        with open(json_file_path, 'w') as file:
            json.dump(data, file, indent=2)
        print(f"Mis à jour {key_mapping[key]}: {data[key_mapping[key]]}")

# Fonction de rappel pour les pressions de touches
def on_key_event(event):
    if event.event_type == 'down' and event.name in key_mapping:
        update_json(event.name)

# Enregistrer le gestionnaire d'événements
keyboard.hook(on_key_event)

# Garder le programme en cours d'exécution
keyboard.wait('esc')