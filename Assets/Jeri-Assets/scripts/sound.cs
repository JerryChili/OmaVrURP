using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour
{
    // Start is called before the first frame update

    public AudioClip impact;
    AudioSource audioSource;

    public void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void OnCollisionEnter(Collision col)
    {
        audioSource.PlayOneShot(impact, GetComponent<Rigidbody>().velocity.magnitude);
    }

    // Update is called once per frame
    void Update()
    {
        //6
    }
}
