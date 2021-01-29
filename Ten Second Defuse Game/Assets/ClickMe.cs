using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickMe : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public BoxCollider2D boxCollider2D;
    public Sprite cutWireSprite;
    public AudioSource audioSource;
    public bool isGameWinWire;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(BombSpriteChange.caseOpen == true && spriteRenderer.enabled == false)
        {
            spriteRenderer.enabled = true;
            boxCollider2D.enabled = true;
        }
    }

    private void OnMouseDown()
    {
        if(BombSpriteChange.gameBegin == true)
        {
            spriteRenderer.sprite = cutWireSprite;
            audioSource.Play();
        }

        if(isGameWinWire == true)
        {
            BombSpriteChange.gameWin = true;
        }
        
    }
}
