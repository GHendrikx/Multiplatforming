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

    private void Awake()
    {
        aSource = Camera.main.GetComponent<AudioSource>();
        aSource.clip = clip;
        RB = GetComponent<Rigidbody>();
    }

    private void OnEnable()
    {
        if (RB == null)
            Awake();

        AddForce();
    }

    private void AddForce()
    {
        PlaySoundClip();
        RB.AddForce(new Vector3(0, force*0.05f, force));
    }

    private void PlaySoundClip()
    {
        aSource.Play();
    }

    private void OnCollisionEnter(Collision collision)
    {
        //PlayExplosion add an awesome EXPLOSION PARTICLE EFFECT to the game

        Pool.Instance.ReturnChild();

        explosion.transform.position = collision.transform.position;
        explosion.gameObject.SetActive(true);
        explosion.Play();

        TimerManager.Instance.AddTimer(() => { explosion.gameObject.SetActive(!explosion.gameObject.activeInHierarchy); }, 2);

        IWillBeBack = true;
    }
}
