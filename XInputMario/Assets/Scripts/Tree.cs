using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    void Update() {
        if (transform.position.z <= -75)
            PositionReset();
    }

    public void PositionReset()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, 1500);
    }
}
