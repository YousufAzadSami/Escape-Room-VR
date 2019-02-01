using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowableSound : MonoBehaviour {

    AudioClip audioClip;
    AudioSource audioSource;

    void Start()
    {
        audioClip = Resources.Load("Assets/Audio/ObjectDrop.wav") as AudioClip;
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = audioClip;
    }

    // Update is called once per frame
    void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Thorowabel Sound");
        float audioLevel = collision.relativeVelocity.magnitude / 10.0f;
        audioSource.PlayOneShot(audioClip, audioLevel);
    }
}
