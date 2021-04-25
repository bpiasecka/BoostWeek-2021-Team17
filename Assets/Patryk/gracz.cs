using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gracz : MonoBehaviour
{
    public float driving, laser, fire, light, dynamo;
    public float maxEnergy = 100;
    public float currentEnergy;

    public float minusEnergy;

    public Material baterja;
    //public SourceBar energyBar;

    public bool silnik;
    public bool ogien;
    public bool swiatlo, topLight;

    float e1;
    float e2;
    float e3, e4;
    float d1;

    public int energyControl;

    void Start()
    {
        PlayerPrefs.SetInt("energy", 1);
        currentEnergy = maxEnergy;
       // energyBar.SetMaxEnergy(maxEnergy);

        swiatlo = false;
        ogien = false;
        silnik = false;

        e1 = 0;
        e2 = 0;
        e3 = 0;
        d1 = 0;

        StartCoroutine(EnergiaCykl());
    }

    public void Update()
    {
        
    }

    IEnumerator EnergiaCykl()
    {
        yield return new WaitForSeconds(1);

        baterja.SetFloat("_EnergyAmount", currentEnergy);
        minusEnergy = e1 + e2 + e3 + e4;

        currentEnergy -= minusEnergy;

        energyControl = PlayerPrefs.GetInt("energy");
        // energyBar.SetEnergy(currentEnergy);
        if (currentEnergy > maxEnergy)
        {
            currentEnergy = 100;
        }

        if (currentEnergy < 0)
        {
            PlayerPrefs.SetInt("energy", 0);
            currentEnergy = 0;
            SilnikOff();
            SwiatloOff();
            OgienOff();
            LightOff();
        }
        if (currentEnergy > 0)
        {
            PlayerPrefs.SetInt("energy", 1);
        }


        //powrót do cyklu
        StartCoroutine(EnergiaCykl());
    }

    public void SilnikStart()
    {
        e1 = driving;
        silnik = true;
    }

    public void SilnikOff()
    {
        silnik = false;
        e1 = 0;
    }

    public void SwiatloStart()
    {
        e2 = laser;
        swiatlo = true;
    }

    public void SwiatloOff()
    {
        e2 = 0;
        swiatlo = false;
    }

    public void OgienStart()
    {
        e3 = fire;
        ogien = true;
    }

    public void OgienOff()
    {
        e3 = 0;
        ogien = false;
    }

    public void DynoOn()
    {
        d1 = dynamo;
        currentEnergy += d1;
    }

    public void DynoOff()
    {
        d1 = 0;
    }

    public void LightOn()
    {
        e4 = light;
        topLight = true;
    }

    public void LightOff()
    {
        e4 = 0;
        topLight = false;
    }

    public void Hajsiwo()
    {
        currentEnergy = maxEnergy;
    }
}
