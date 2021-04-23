using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarScript : MonoBehaviour
{
    public float speed;
    public float energyLevel, energyUsage;
    public bool isDriving = false;

    void Start()
    {
    }

    void Update()
    {
        if(isDriving)
        {
            Drive();
        }
    }

    private void Drive()
    {
        if (energyLevel > 0f)
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
            energyLevel = Mathf.Max(energyLevel - energyUsage * Time.deltaTime, 0f);
        }
        else
            isDriving = false;
    }

    public void OnDriveButtonClicked()
    {
        isDriving = !isDriving;
    }
}
