using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timers;

public class MobileXInput : XInput
{
    public override event HorizontalMovement horizontalMovement;
    public override event VerticalMovement verticalMovement;
    public override event PlayerAction action;
    private bool canThrow;

    // Start is called before the first frame update
    public override void Start()
    {
        //setting up Input
        horizontalMovement += player.HorizontalMove;
        action += player.Action;
        canThrow = true;
        Screen.orientation = ScreenOrientation.Landscape;
    }

    public override void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            Vector2 touchPosition = touch.position;

            if (touchPosition.x > (Screen.width * 0.75))
                horizontalMovement(1);
            else if(touchPosition.x < (Screen.width * 0.25))
                horizontalMovement(-1);
            else
                action();
        }
    } 
}
