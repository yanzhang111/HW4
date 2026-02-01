# HW4
## Devlog
I thought this project would be very simple, but because the teacher asked me to use the structure of MVC and events, I couldn’t write everything in the same script as usual. At first, I only separated Player, UI, and sound just to meet the homework requirements, but as I continued, I found this really made the whole game easier to manage.


Like PlayerController, I used to let it handle score, UI, sound effects and everything together, but this time it can only send out events and not handle extra game logic. After finishing it, I saw that the code became much cleaner. The Player only does player behavior, and it doesn’t make other systems messy. GameController works as a Singleton, so it collects all the events in one place and handles things like adding points or telling the UI to update. This is much clearer than my old way where everything was written all over the place.


UIController and AudioController also only listen to events and then update visuals or play sounds, without any game logic inside, which makes them easier and safer to change. Pipe is responsible for checking when the player passes by and then triggering the event for scoring at the right time.

## Open-Source Assets
-【2D Platfrom cany paradise】（https://assetstore.unity.com/packages/2d/environments/2d-platformer-candy-paradise-320451）-cloud sprite
-【FREE Casual Game SFX Pack】（https://assetstore.unity.com/packages/audio/sound-fx/free-casual-game-sfx-pack-54116）-sound effects
