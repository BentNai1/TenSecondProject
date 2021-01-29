using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpriteChange : MonoBehaviour
{
    Animator anim;
    public static bool caseOpen = false;
    public static bool gameBegin = false;
    public static bool gameLoss = false;
    public static bool gameWin = false;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

        
    }

    // Update is called once per frame
    void Update()
    {
        if (caseOpen == true)
            {
                ChangeAnimOpen();
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
    }
}
