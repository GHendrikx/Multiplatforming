using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timers;

public class Player : MonoBehaviour
{
    public float JumpForce;
    [SerializeField]
    [Range(0,10)]
    private float speed;
    [SerializeField]
    [Range(0,45)]
    private int yOffset;
    [SerializeField]
    [Range(0,40)]
    private int zOffset;
    private bool canThrow = true;
    [SerializeField]
    private Rigidbody myRb;
    [SerializeField]


    public void HorizontalMove(float steer) 
    {
        Vector3 movement;
        Debug.Log("Steer : " + steer);
        movement = new Vector3(myRb.position.x + (steer * speed), transform.localPosition.y, transform.localPosition.z);
        Debug.Log("movement.x : " + movement.x);
        myRb.MovePosition(movement);
        //myRb.MovePosition( movement * speed * Time.deltaTime);
    }

    public void Action() 
    {
        if (canThrow)
        {
            //throw car
            Transform truck = Pool.Instance.TakeCarTransform();
            truck.position = new Vector3(this.transform.position.x, transform.position.y + yOffset, transform.position.z + zOffset);
            canThrow = false;
            TimerManager.Instance.AddTimer(() => { canThrow = !canThrow; }, 1);
        }
    }
}