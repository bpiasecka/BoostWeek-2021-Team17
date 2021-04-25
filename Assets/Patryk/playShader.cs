using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class playShader : MonoBehaviour
{

    public VisualEffect efect;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            efect.Play();
        }

    }
}
