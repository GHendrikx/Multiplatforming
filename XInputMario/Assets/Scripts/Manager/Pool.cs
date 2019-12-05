using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pool : Singleton<Pool>
{
    [SerializeField]
    private List<Truck> childList;

    // Take Car
    public Transform TakeCarTransform()
    {
        Transform child = childList[0].transform;
        child.gameObject.SetActive(true);
        return child;
    }

    //Returns car
    public void ReturnChild()
    {
        for (int i = 0; i < childList.Count; i++)
        {
            if (childList[i].IWillBeBack)
            {
                Truck truck = childList[i];
                truck.transform.parent = this.transform;
                truck.RB.velocity = Vector3.zero;
                truck.RB.angularVelocity = Vector3.zero;
                truck.transform.position = Vector3.zero;

                truck.IWillBeBack = false;
                truck.explosion.gameObject.SetActive(false);
                truck.gameObject.SetActive(false);
                truck.transform.rotation = Quaternion.identity;
            }
        }
    }
}
