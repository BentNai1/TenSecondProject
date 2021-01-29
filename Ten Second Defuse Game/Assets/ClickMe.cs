using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickMe : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public BoxCollider2D boxCollider2D;
    public Sprite cutWireSprite;
    public bool isGameWinWire;
    // Start is called before the first frame update
    void Start()
    {
        
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
        }

        if(isGameWinWire == true)
        {
            BombSpriteChange.gameWin = true;
        }
        
    }
}
