using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeScroling : MonoBehaviour
{
    [SerializeField]
    private int speed;
    private List<Transform> trees;

    private void Start()
    {
        trees = new List<Transform>();

        for (int i = 0; i < this.transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.AddComponent<Reset>();
            trees.Add(transform.GetChild(i).transform);
        }

    }

    void Update()
    {
        for (int i = 0; i < trees.Count; i++)
        {
            trees[i].position = new Vector3(trees[i].transform.position.x, trees[i].transform.position.y,
                trees[i].transform.position.z - (speed * Time.deltaTime));
        }
    }
}
