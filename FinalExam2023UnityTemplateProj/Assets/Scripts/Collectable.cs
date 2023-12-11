using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Collectable : MonoBehaviour
{

    [SerializeField]
    private int pickup_value = 1;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            // Handle pickup-specific logic (e.g., add score, spawn particle effect, etc)
            Destroy(gameObject);
        }
    }


}
