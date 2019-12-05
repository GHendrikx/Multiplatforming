using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timers;

public class Player : MonoBehaviour
{
    public float JumpForce;
    private int speed;
    [SerializeField]
    [Range(0,45)]
    private int yOffset;
    [SerializeField]
    [Range(0,40)]
    private int zOffset;
    private bool canThrow = true;


    public void HorizontalMove(float Vector) 
    { 
        
    }
    public void Jump(float force) { }
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