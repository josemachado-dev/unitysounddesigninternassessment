# Unity Sound Design Intern Assessment Considerations

## How to run the project
Download or clone the repository
Open the project on Unity version 2020.3.18f1.
You should be able to run the game, and hear all of the sound elements.
If anything described in this document does not appear to be working, please contact me at hi@josemachado.dev and I’ll sort it out as soon as I can!

## Sound Design Choices
Since I was told to only spend a day (max 2) on this project, all the sounds I’ve used were sourced from sound libraries (mostly the free GDC Soniss and FTUS ones, but also some others I’ve acquired over the years) - however, I did edit them, as described below. Given a bit more time, I would’ve considered doing some outdoor recordings and/or foley (especially for the character noises - walk, jump, land).
Completing the entire assignment took me about a day of work, so I can say I was fully within the given timeframe.

### AMB sounds
#### Forest day
Started by layering multiple “forest ambiences”, as to create an unique sound, that would be coherent with the given scene. I’ve gain staged them, run them through an EQ and a touch of compression, to make the soundscape feel coherent. I also edit the sound in a way that it would seamlessly loop. Since this is an ambience for a 2D game, directionality doesn’t matter for the ambience sounds, I’ve rendered it as a mono .ogg file, and sent it to the AMB folder in Unity, set its Spatial Blend to 2D, and dragged it to Ambience - Forest Day Audio Source.
#### Forest night
Same principles as Forest Day, except obviously taking into consideration the change in scenery. The wolf cry was run through some heavy EQ and RX8 to remove the wind sounds that were also in that file.
#### Script to change volumes
By this time, I realised there was no smooth transition between being inside the cave and outside, so I made a very rough script to change the volumes of each AudioSource accordingly. Given more time, I’d make this transitions smoother, but for now it works as a proof of concept.
#### Ruins
Given this is a mystical place, where we eventually see our character change both the day and themselves, I went for a low drone plus the water that is present in the scene. Since this is still an AMB sound, I also exported it to mono and set the Spatial Blend as 2D. I made a couple of new AudioSources called “Shimmers”, adding some occasional shimmering 3D sound sources, to spice up the “mystical feel” of the ruins. These shimmers were used by heavily cropping an eerie sounds from a library, and applying multiple effects such as reverb, echo and delay. I also added some directional fire sound, coming from the torches, using the same principles as the ones for the shimmer effects, but without the heavy processing.

### BGM
For the Background Music, I decided to search for Royalty Free songs that would fit the aesthetic of the game we have at hand. I started my search by looking for mysterious but not too dark songs, so that it would work with both the Day and Night scenes. However, if I had more time to implement things, I would suggest a variation of the musical theme, or a new song for each of the day cycles.
I went with “Our Hopes and Dreams” by Steve Oxen, because I felt it lent itself to the emotional journey it was being portrayed in this small scene. I got the song from https://www.fesliyanstudios.com/

### SFX
Note: for the “Shimmer SFXs” or the “Torches SFXs”, please refer to the Ruins chapter.
#### Walking
I searched my libraries for some suitable walking sounds I had, cut them appropriately, renamed them to keep coherency between the files, and implemented them in-engine. This was done both for the “Soft Steps”, relating to walking on the grass, and the “Hard Steps” for walking on stone.
Given more time, more variation would’ve been created, and also alternate sounds for Sara Variant.
#### Landing
The landing SFXs where achieved by placing a couple of steps in a rapid succession, with some EQ and compression applied to them, and a bottom “thump” layer to sell the collision with the ground.
#### Jumping
This SFX was achieved by me recording a quick strain voice line, cleaning up the audio, and applying a formant shifter to get closer to what the character should sound like. Preferably, we would have multiple of these type of lines done by a voice actor/actress to implement, and variants to the “Sara Variant” as well, but given time limits and the constrains of this exercise, I left it at that.
#### Transformation Sequence
I identified that, during the transformation sequence, there should be playing in the timeline 2 audio effects that were not present in the project: an earthquake and an energy explosion. So, I re-implemented them, so we had the full project with sound.
##### Earthquake
The earthquake sound was sourced from an audio library, and only a small EQ pass, gain staging and a cut was applied, because the original sound was already relevant to the clip.
##### Explosion
The earthquake sound was divided into 4 segments: the build up, the explosion, the implosion and the energy wave.
The build up segment was done by creating a riser. To this effect, I took a kick sample, reversed it, applied some EQ and reverb.
The Explosion Segment was done by layering multiple designed fire items, applying a bit of compression to glue things together, and applying reverb to it.
The Implosion is a reversed explosion, without further effects.
The Energy Wave was created by putting a kick sample through multiple layers of reverberation and echoes.
All of these elements were also blended in the Timeline sheet, as to not cut from one to another, but instead be a bit smoother.

#### UI
For the UI, I used the sound of a clave, pitched it down a bit and added a very faint reverb, to make it closer to the timbric properties of knocking on wood, to add an organic element of sound to the UI, keeping in theme with the rest of the game.
