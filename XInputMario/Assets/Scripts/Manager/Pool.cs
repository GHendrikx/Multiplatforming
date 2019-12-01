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
                childList[i].IWillBeBack = false;
                childList[i].transform.position = Vector3.zero;
                childList[i].gameObject.SetActive(false);
            }
        }
    }
}
