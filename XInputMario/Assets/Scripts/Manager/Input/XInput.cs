using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// SuperClass
/// </summary>
public abstract class XInput : MonoBehaviour, InputListeners
{
    public abstract event HorizontalMovement horizontalMovement;
    public abstract event VerticalMovement verticalMovement;
    public abstract event PlayerAction action;

    public Player player;

    public abstract void Start();
    public abstract void Update();

}
