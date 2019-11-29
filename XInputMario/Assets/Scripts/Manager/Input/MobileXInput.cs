using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileXInput : XInput
{
    public override event HorizontalMovement horizontalMovement;
    public override event VerticalMovement verticalMovement;
    public override event PlayerAction action;

    // Start is called before the first frame update
    public override void Start()
    {
        //setting up Input
        horizontalMovement += player.HorizontalMove;
        verticalMovement += player.Jump;
        action += player.Action;
        Screen.orientation = ScreenOrientation.Landscape;
    }

    public override void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            Vector2 position = touch.position;

            if (position.x > (Screen.width * 0.75f))
                horizontalMovement(10);
            else if (position.x < (Screen.width * 0.25f))
                horizontalMovement(-10);
            else
            {
                //do action of jump
            }

        }
    }
}
