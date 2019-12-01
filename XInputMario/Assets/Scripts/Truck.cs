using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timers;
public class Truck : MonoBehaviour
{
    [SerializeField]
    private float force;
    public AudioClip clip;
    private AudioSource aSource;
    public bool IWillBeBack;
    
    private void Start()
    {
        aSource = Camera.main.GetComponent<AudioSource>();
        aSource.clip = clip;
        AddForce();
    }


    private void AddForce()
    {
        GetComponent<Rigidbody>().AddForce(new Vector3(0, force*0.05f, force));
        PlaySoundClip();
    }

    private void PlaySoundClip()
    {
        aSource.Play();
    }

    private void OnCollisionEnter(Collision collision)
    {
        //PlayExplosion add an awesome EXPLOSION PARTICLE EFFECT to the game
        IWillBeBack = true;
        TimerManager.Instance.AddTimer(Pool.Instance.ReturnChild, 5);
    }
}
