using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriveButtonScript : MonoBehaviour
{
    private CarScript car;
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.CompareTag("Player"))
        {
            if (car == null)
                car = GameObject.FindObjectOfType<CarScript>();
            car.OnDriveButtonClicked();
        }
        
    }
}
