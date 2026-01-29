using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public delegate void Delegate();
    public event Delegate whatshouldInamethiscode;

    /*
    (3) The player can flap with SPACE, which:
    makes the player pop upwards, but gravity pulls them down.
    plays a sound.

    (4) The player loses if they collide with a pipe, which:
    plays a sound.
    stops the game.
    */
}
