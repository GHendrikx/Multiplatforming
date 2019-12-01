using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float JumpForce;
    private int speed;
    [SerializeField]
    [Range(0,10)]
    private int yOffset;
    private int y;
    private float rotater;

    private void Start() =>
        rotater = transform.eulerAngles.y;

    private void Update() =>
        transform.Rotate(new Vector3(transform.rotation.eulerAngles.x,
            (transform.rotation.eulerAngles.y + 2) % 360,
            transform.rotation.eulerAngles.z));

    public void HorizontalMove(float Vector) 
    { 
        
    }
    public void Jump(float force) { }
    public void Action() 
    {
        //throw car
        Transform truck = Pool.Instance.TakeCarTransform();
        truck.position = new Vector3(this.transform.position.x, transform.position.y + yOffset,transform.position.z);
    }
}
