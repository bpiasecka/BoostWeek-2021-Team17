using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dziura : MonoBehaviour
{
    public int uzupe³nij;
    public int bum;
    public bool zalewa;

    public GameObject dziurka;
    // Start is called before the first frame update
    void Start()
    {
        dziurka.SetActive(false);
        uzupe³nij = bum;
        zalewa = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (zalewa == true)
        {
            uzupe³nij -= 1;
            if (uzupe³nij <= 0)
            {
                dziurka.SetActive(true);
            }
        }
    }

    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Input.GetKey(KeyCode.Q))
            {
                zalewa = true;
            }
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            zalewa = false;
            uzupe³nij = bum;
        }
    }
}
