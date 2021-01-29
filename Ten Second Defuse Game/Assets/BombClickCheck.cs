using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombClickCheck : MonoBehaviour
{
    
    //public ScriptableObject = 
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
        //bombScript.ChangeAnimOpen();
        if(BombSpriteChange.gameBegin == true && BombSpriteChange.caseOpen == false)
        {
            
            BombSpriteChange.caseOpen = true;
            Destroy(gameObject);
        }
        
    }

}
