using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager singleton;

    public AudioClip[] clips;
    AudioSource sumberAudio;

    private void Awake()
    {
        sumberAudio = GetComponent<AudioSource>();
        singleton = this;
    }

    public void PlaySound(int indexClip)
    {
        sumberAudio.PlayOneShot(clips[indexClip]);
    }

    public void stopSound()
    {
        sumberAudio.Stop();
    }
}
