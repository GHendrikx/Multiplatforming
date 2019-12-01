using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// SuperClass
/// </summary>
public abstract class XInput : InputListeners
{
    public abstract event HorizontalMovement horizontalMovement;
    public abstract event PlayerAction action;

    protected Player player;

    public abstract void Start();
    public abstract void Update();

    public XInput(Player player)
    {
        this.player = player;
    }
}
