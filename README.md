# Room Designer 3000
Abdullah Alhasni & Sameer Manzoor

Rearranging the furniture in your house can be difficult since moving furniture around is difficult. This project should help make this process much easier. In this software the user will be able to change the position of the furniture virtually and see how the final product looks before actually moving the furniture, making it easier to visualize and get a final look that suits them best. This software can also be used by interior designers and architects in the future to design rooms, houses, offices etc, satisfying their clients.

The entire project was done in Unity and in the C# language. There were two scripts, one script to implement the functions that move you from one scene to another using SceneManagement, and one script that links the value of the scrollbars with the positions of the furniture in the designer scene.

We used the Oculus Integration asset, and the XR Interaction Toolkit, and the Big Furniture Pack. In every scene, there was an XR Origin with the Left and Right Controller. We gave each Controller a model of a hand. The main menu scene had a snippet of one of the rooms as a background and two buttons, the Quit the App button and the Design your Room button. The ‘choose’ scene has four buttons, each one leads to each of the four remaining scenes. Three of these scenes are sample scenes with pre-organized furniture, and a ‘Return to the Main Menu’ button stuck to the wall.

There may be some issues when it comes to moving and rotating using the Controllers’ joysticks, that’s why it is best to choose a big roomscale boundary in the headset then walk around the room.

Currently in this prototype we can just move the furniture around and redesign the room with the limited furniture provided. In the future we will be making this software a lot more user friendly by adding more options like:
- Grabbing objects in VR instead of moving the slider to change their positions
- Changing the furniture color
- Changing the furniture material
- Changing the color of the walls
- Asking the user for the dimensions of their room, furniture, etc…
