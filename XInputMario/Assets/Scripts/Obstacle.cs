using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField]
    private int speed;
    private List<Transform> obstacles;

    private void Start()
    {
        obstacles = new List<Transform>();

        for (int i = 0; i < this.transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.AddComponent<Reset>();
            obstacles.Add(transform.GetChild(i).transform);
        }
    }

    void Update()
    {
        for (int i = 0; i < obstacles.Count; i++)
        {
            obstacles[i].position = new Vector3(obstacles[i].transform.position.x, obstacles[i].transform.position.y, obstacles[i].transform.position.z - (speed * Time.deltaTime));
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
            collision.gameObject.GetComponent<Reset>().PositionReset();
    }
}
