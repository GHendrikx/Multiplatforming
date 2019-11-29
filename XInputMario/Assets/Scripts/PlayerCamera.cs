using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    [SerializeField]
    private Player player;
    [SerializeField]
    private float distance;

    private void Update() =>
        this.gameObject.transform.position = new Vector3(player.transform.position.x, 
                                                        player.transform.position.y, 
                                                        player.transform.position.z - distance);
    

}
