using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCXInput : XInput
{
    public override event HorizontalMovement horizontalMovement;
    public override event PlayerAction action;

    public PCXInput(Player player) :base(player)
    {

    }
    
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
            horizontalMovement(1);
        else if(Input.GetKey(KeyCode.A))
            horizontalMovement(-1);

        if (Input.GetKeyUp(KeyCode.Space))
            action();
    }
}
