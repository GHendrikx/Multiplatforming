using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void HorizontalMovement(float x);
public delegate void VerticalMovement(float z);
public delegate void Jump(float force);
public delegate void PlayerAction();

public interface InputListeners
{
    event VerticalMovement verticalMovement;
    event HorizontalMovement horizontalMovement;
    event Jump jump;
    event PlayerAction action;
}
