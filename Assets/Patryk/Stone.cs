using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Stone : MonoBehaviour
{
    public int zniszcz;
    public int bum;
    public bool bije;
    // Start is called before the first frame update
    void Start()
    {
        zniszcz = bum;
        bije = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(bije == true)
        {
            zniszcz -= 1;
            if(zniszcz <= 0)
            {
                Destroy(gameObject);
            }
        }
    }

    public void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if (Input.GetKey(KeyCode.Q))
            {
                bije = true;
            }
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            bije = false;
            zniszcz = bum;
        }
    }
}
