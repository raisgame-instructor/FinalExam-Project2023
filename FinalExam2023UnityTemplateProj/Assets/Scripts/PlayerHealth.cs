using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField]
    private float max_health;
    private float health;

    private void Awake()
    {
        health = max_health;
    }

    public void ReceiveDamage(float damage)
    {
        health = Mathf.Clamp(health - damage, 0, max_health);

        if(health <= 0)
        {
            // player dies
            OnDeath();
        }
    }

    private void OnDeath()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
