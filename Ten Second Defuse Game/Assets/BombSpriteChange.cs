using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpriteChange : MonoBehaviour
{
    Animator anim;
    public AudioSource audioSource;
    public static bool caseOpen = false;
    public static bool gameBegin = false;
    public static bool gameLoss = false;
    public static bool gameWin = false;
    private bool openTriggered = false;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();

        
    }

    // Update is called once per frame
    void Update()
    {
        if (caseOpen == true && openTriggered == false)
            {
                ChangeAnimOpen();
                openTriggered = true;
            }

        if (gameLoss == true)
        {
            ExplosionController.explosionSound = true;
            
            Destroy(gameObject);
        }

        if (gameWin == true)
        {
            anim.enabled = false;
        }
    }

    public void ChangeAnimOpen()
    {
        anim.SetBool("BombOpened", true);
        audioSource.Play();
    }
}
