using UnityEngine;
using System.Collections;

public class Audio : MonoBehaviour
{
    public AudioSource Bite;
    public AudioSource pickupAudio;
    public AudioSource explodeAudio;
    public static Audio audio;
    void Start()
    {
        audio = this;
    }
}