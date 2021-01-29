using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickMe : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite cutWireSprite;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if(BombSpriteChange.gameBegin == true)
        {
            spriteRenderer.sprite = cutWireSprite;
        }
        
    }
}
