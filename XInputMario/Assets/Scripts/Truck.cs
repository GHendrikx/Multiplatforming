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
    public ParticleSystem explosion;
    public bool IWillBeBack;
    public Rigidbody RB
    {
        get;
        private set;
    }

    private void Start()
    {
        aSource = Camera.main.GetComponent<AudioSource>();
        aSource.clip = clip;
        RB = GetComponent<Rigidbody>();
    }

    private void OnEnable()
    {
        if (RB == null)
            Start();

        AddForce();
    }

    private void AddForce()
    {
        RB.AddForce(new Vector3(0, force*0.05f, force));
        PlaySoundClip();
    }

    private void PlaySoundClip()
    {
        aSource.Play();
    }

    private void OnCollisionEnter(Collision collision)
    {
        //PlayExplosion add an awesome EXPLOSION PARTICLE EFFECT to the game
        explosion.gameObject.SetActive(true);
        explosion.Play();
        IWillBeBack = true;
        TimerManager.Instance.AddTimer(Pool.Instance.ReturnChild, 5);
    }
}
