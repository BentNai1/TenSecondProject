using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictorySpeach : MonoBehaviour
{
    public AudioSource audioSource;
    

    private bool speachOn = false;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (BombSpriteChange.gameWin == true && speachOn == false)
        {
            audioSource.Play();
            speachOn = true;
        }
    }
}
