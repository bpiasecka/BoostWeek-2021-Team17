using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SourceBar : MonoBehaviour
{

    public Slider sliderek;

    

    

    public void SetMaxEnergy(int energy)
    {
        sliderek.maxValue = energy;
        sliderek.value = energy;
    }

    public void SetEnergy(int energy)
    {
        sliderek.value = energy;
    }
    // Start is called before the first frame update
   

    
}
