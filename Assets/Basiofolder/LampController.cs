using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampController : MonoBehaviour
{
    public GameObject lampGameObject;
    public Light light;
    public bool SetLightPositionMode = false;

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            SetLight();
        }
    }

    public void SetLight()
    {
        light.enabled = !light.enabled;
    }



}
