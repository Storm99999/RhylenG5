# RhylenG5
A usermode application which directly communicates with ViGEmBus to allow Controller Aim Assist functionality. 

# How does it work?
RhylenG5 uses the ViGEmBus-Driver to create a virtual XBox360-Controller which is then recognized by your game (in most cases, 1v1.lol), after making a successful connection between the user and virtual controller it will continue to spam a button, which will keep the game thinking you are playing on a Controller, even though you're using a keyboard. All these factors combined make the aim assist trigger.

# Bugs
on 1v1.lol, there's not many but a few recognizable ones, like exiting build mode randomly

# How to setup
* Install ViGEmBus - https://github.com/nefarius/ViGEmBus/releases/tag/v1.22.0
* Run the exe from source binaries
* Make your edit bind in 1v1.lol settings the B key (spam it because it's hard to do 1st try), once you press E, RhylenG5 will translate to controller input (B key on XBox) (you can compile yourself and change your edit bind in source)
* Press on switch building mode to another key
* Disconnect any physical controllers you may have
