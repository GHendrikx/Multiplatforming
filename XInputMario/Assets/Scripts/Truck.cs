using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Truck : MonoBehaviour
{
    [SerializeField]
    private float force;
    private AudioClip clip;
    private AudioSource aSource;
    private void Start()
    {
        aSource = Camera.main.GetComponent<AudioSource>();
        aSource.clip = clip;

        AddForce();
    }


    private void AddForce()
    {
        GetComponent<Rigidbody>().AddForce(new Vector3(0, force*0.05f, force));
        StartCoroutine(PlaySoundClip());
    }

    private IEnumerator PlaySoundClip()
    {
        // TODO: Downloading the "Duke of hazzard" horn
        yield return new WaitForSeconds(2);
        aSource.Play();
    }

    private void OnCollisionEnter(Collision collision)
    {
        //TODO: Return to pool
    }
}
