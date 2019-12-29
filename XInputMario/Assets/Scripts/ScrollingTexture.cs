using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//animating texture
public class ScrollingTexture : MonoBehaviour
{
    private float scrollZ = 5f;
    public Renderer renderer;
    public bool StopTexture;

    private void Start() =>
        renderer = GetComponent<Renderer>();

    // Update is called once per frame
    private void Update()
    {
        if (!StopTexture)
        {
            float offsetZ = Time.time * scrollZ;
            renderer.material.mainTextureOffset = new Vector2(
                renderer.material.mainTextureOffset.x, -offsetZ);
        }
     }
}
