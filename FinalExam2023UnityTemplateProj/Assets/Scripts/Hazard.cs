using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour
{
    [SerializeField]
    private float damage = 0.5f;

    [SerializeField]
    private bool damage_over_time = false; // whether to apply damage every second or apply once

    private bool can_damage = true;

    private void OnTriggerEnter(Collider other)
    {
        if(!damage_over_time)
        {
            ApplyDamage(other.gameObject);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        can_damage = true;
    }

    private void OnTriggerStay(Collider other)
    {
        if(damage_over_time && can_damage)
        {
            ApplyDamage(other.gameObject);
            can_damage = false;
            Invoke(nameof(EnableDamage), 1.0f);
        }
    }

    private void ApplyDamage(GameObject other)
    {
        if(other.CompareTag("Player"))
        {
            PlayerHealth health = other.GetComponent<PlayerHealth>();
            if(health)
            {
                health.ReceiveDamage(damage);
                print("Applying Damage");
            }
        }

    }

    private void EnableDamage()
    {
        can_damage = true;
    }

}
