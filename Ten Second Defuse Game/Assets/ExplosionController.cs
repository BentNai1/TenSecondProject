﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionController : MonoBehaviour
{
    public AudioSource audioSource;
    public SpriteRenderer spriteRenderer;

    public static bool explosionSound = false;

    private bool explosionOn = false;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (explosionSound == true && explosionOn == false)
        {
            explosionOn = true;
            audioSource.Play();
            spriteRenderer.enabled = true;
        }
    }
}
