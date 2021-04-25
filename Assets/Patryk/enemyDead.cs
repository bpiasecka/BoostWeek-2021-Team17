using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class enemyDead : MonoBehaviour
{
    //public VisualEffect efect;

    
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "lazer")
        {
            //efect.Play();
            Destroy(gameObject);
        }
        
    }
}
