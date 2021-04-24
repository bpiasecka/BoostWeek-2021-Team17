using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shader : MonoBehaviour
{

    public Material baterja;
    public float moc;
    public float maxMoc;
    
    // Start is called before the first frame update
    void Start()
    {
        baterja.SetFloat("_EnergyAmount", moc );
        
    }

    // Update is called once per frame
    void Update()
    {
        baterja.SetFloat("_EnergyAmount", moc);
    }
}
