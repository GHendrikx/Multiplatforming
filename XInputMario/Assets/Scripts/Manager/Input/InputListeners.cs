using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void HorizontalMovement(float x);
public delegate void PlayerAction();

public interface InputListeners
{
    event HorizontalMovement horizontalMovement;
    event PlayerAction action;
}
