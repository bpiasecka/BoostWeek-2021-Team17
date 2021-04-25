using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p2play : MonoBehaviour
{
    public GameObject pay;

    public gracz place;

    public int placem;

    // Start is called before the first frame update
    void Start()
    {
        placem = 1;
        pay.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("energy") == 0 & placem == 1)
        {
            pay.SetActive(true);
        }
    }

    public void Payer()
    {
        place.Hajsiwo();
        placem = 0;
        pay.SetActive(false);
    }

    public void Zydek()
    {
        pay.SetActive(false);
    }
}
