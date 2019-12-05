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
        for (int i = 0; i < trees.Count; i++)
        {
            trees.Add(transform.GetChild(i).transform);
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < trees.Count; i++)
        {
            trees[i].transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - speed * Time.deltaTime);       
        }
    }
}
