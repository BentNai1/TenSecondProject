using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionController : MonoBehaviour
{
    public static bool explosionSound = false;
    private bool explosionOn = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (explosionSound == true && explosionOn == false)
        {
            explosionOn = true;
        }
    }
}
