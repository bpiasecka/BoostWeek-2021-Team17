using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyButton : MonoBehaviour
{
    public float energy;
    private CarScript car;

    public void Start()
    {
        car = GameObject.FindObjectOfType<CarScript>();
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            car.energyLevel += energy;
        }
    }

}