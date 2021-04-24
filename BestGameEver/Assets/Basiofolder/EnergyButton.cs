using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyButton : MonoBehaviour
{
    public float energySpeed;
    private CarScript car;
    public  bool isGainingEnergy = false;

    public void Start()
    {
        car = GameObject.FindObjectOfType<CarScript>();
    }

    public void Update()
    {
        if (isGainingEnergy)
            car.energyLevel += energySpeed * Time.deltaTime;
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Player"))
        {
            isGainingEnergy = true;
        }
    }

    public void OnCollisionExit(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            isGainingEnergy = false;
        }
    }
}
