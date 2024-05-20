using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("---------- audio source -----------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("---------- audio clip -----------")]
    public AudioClip background;
    public AudioClip odetojoy;
    public AudioClip moonlight;
   public AudioClip notaGiusta;


    private void Start() {
        musicSource.clip = background;
        musicSource.Play();

    }

   
}
