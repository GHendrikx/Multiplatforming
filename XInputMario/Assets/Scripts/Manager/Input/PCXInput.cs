using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCXInput : XInput
{
    public override event HorizontalMovement horizontalMovement;
    public override event VerticalMovement verticalMovement;
    public override event PlayerAction action;
    
    // Start is called before the first frame update
    public override void Start()
    {
        //setting up Input
        horizontalMovement = player.HorizontalMove;
        action = player.Action;
    }

    public override void Update()
    {
        if(Input.GetKey(KeyCode.D))
        {

        }
        if(Input.GetKey(KeyCode.A))
        {

        }
    }
}
