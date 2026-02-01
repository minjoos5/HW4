# HW4
## Devlog

- MVC pattern is utilized in my minigame 4 by decoupling player/UI update/audio play classes individually. The Player class defines the control, and the AudioPlayer & UI classes define the view in my game, since the Player class handles the score and events as the player jumps and gains points. The UI and AudioPlayer classes define methods to display the score on screen or play specific audio effects (coin, jump, death), indicating that they manipulate the game's view. For example, AudioPlayer class includes Play(Jump/Death/Point)Sound methods in the class. Player class declares events and manipulates all movements of the player, calling appropriate methods depending on the situation.


- In my minigame, I applied three different events and one locator to control sounds and UI. I declared one int event for point calculation with UI (_scoreEvent), and two void events to play sounds in the game (_jumpEvent & _deathEvent). I applied a locator singleton declared in the player script to manage variables and trigger events across different classes, including the UI and Audio classes. Those events were used to manipulate the audio timing and score calculation by subscribing to audio methods (playjump/death/pointsound) and the UI score method. I was able to decouple the audio and UI from the Player class by using a locator and events (_scoreEvent, _deathEvent, _jumpEvent), which allowed me to call methods without creating SerializeFields to connect game components, which can easily cause multiple errors.

## Open-Source Assets
If you added any other assets, list them here!
- [Brackey's Platformer Bundle](https://brackeysgames.itch.io/brackeys-platformer-bundle) - sound effects
- [Sprout Lands assets](https://cupnooble.itch.io/sprout-lands-asset-pack) - tilemap & chicken assets
