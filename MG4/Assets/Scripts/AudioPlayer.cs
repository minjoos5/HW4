using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    [SerializeField] private AudioSource _jumpAudio;

    [SerializeField] private AudioSource _deathAudio;

    [SerializeField] private AudioSource _pointAudio;

    void Start()
    {
        _jumpAudio = GetComponent<AudioSource>();
        _deathAudio = GetComponent<AudioSource>();
        _pointAudio = GetComponent<AudioSource>();
        
        
    }

    public void PlayJumpSound()
    {
        _jumpAudio.Play();
    }

    public void PlayDeathSound()
    {
        _deathAudio.Play();
    }

    public void PlayPointSound()
    {
        _pointAudio.Play();
    }
}
