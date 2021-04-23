using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorDetector : MonoBehaviour
{
    private PlayerScript player;
    private List<Collider> currentColliders = new List<Collider>();

    public void OnTriggerEnter(Collider other)
    {
        if (player == null)
            player = GameObject.FindObjectOfType<PlayerScript>();
        currentColliders.Add(other);
        player.SetGrounded(true);
    }
    public void OnTriggerExit(Collider other)
    {
        if (player == null)
            player = GameObject.FindObjectOfType<PlayerScript>();
        currentColliders.Remove(other);
        if(currentColliders.Count == 0)
            player.SetGrounded(false);
    }
}
