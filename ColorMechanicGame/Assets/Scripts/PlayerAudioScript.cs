using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudioScript : MonoBehaviour
{
    private AudioSource playerAudioSource;

    private void Start()
    {
        playerAudioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        playerAudioSource.Play();
    }
}
