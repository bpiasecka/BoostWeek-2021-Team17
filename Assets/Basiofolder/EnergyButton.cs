using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyButton : MonoBehaviour
{
    public float energy;
    private gracz energySource;

    public void Start()
    {
        energySource = GameObject.FindObjectOfType<gracz>();
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            energySource.DynoOn();
        }
    }

}