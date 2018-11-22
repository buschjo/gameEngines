- Menue
- Character Auswahl
- Fill degree of the cup
- Empty cup
- borders for Drip area
- Advill (Power Ups)
- Drop Animation
- Bathroom Area (Appearing and Disappearing Bathrooms)
- Sprite Import
-  


Sprite einteilung:
- auf sprite klicken
- in inspector "sprite mode: multiple"
- open sprite editor
- slice
- arrangieren der vierecke um die sprites
--> immer gleiche ausrichtung am Rand
--> vorsicht, dass der Rand des bildes nicht direkt der Rand des slices ist
- "apply"

Animation (Animation und animator View oeffnen):
- gewuenschte sprites auswaehlen
- "create" -> "animation"
- umbenennen und in jeweiligen ordner
- GameObject add Animator Component
- Create Animator (bsp.: DropController) state machine
- Abfolge erstellen (started mit idle state)
- transitions hinzufuegen
-- Exit time an/aus (typischerweise aus)
-- Duration 0
-- Links bei "Parameters" den Trigger erstellen
-- Trigger der State im inspector hinzufuegen
- Animation dem State hinzufuegen (Motion)
Zum automatischen Zerstoeren des Gameobjects nach dem Ablauf der Animation
- dem GameObject ein Script hinzufuegen
- im Script die Methode zum Zerstoeren erstellen
- im "Animation View"
-- GameObject auswaehlen
-- richtige Animation auswaehlen
-- am Ende der Animation "Add Animation Event" (Rechtsklick in grauer Zeile zwischen Zeitanzeige und "Caro" Zeile)
-- im Inspector Function auswaehlen