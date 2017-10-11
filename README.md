# like100bears boat in Unity

This is a quick implementation of a cool effect described by [@like100bears](https://twitter.com/like100bears) in [this article](http://www.like100bears.com/writing/2d-3d-in-gamemaker-studio).

![Blue Boat Example](demo.gif)

The basic idea is to stack slices of a 3d object as 2d sprites, then force orthographic perspective by shifting the slice stack vertically while rotating each piece around its own midpoint. The result is an object that appears to be 3d.

The limitation of this effect is that it only works because of the super limited color palette: the "walls" on the ship wouldn't look right if more colors were used because they wouldn't blend together and trick your eye. Would be great for a minimalist style game!

