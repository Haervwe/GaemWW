using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageHandler : MonoBehaviour
{
    public int health = 1;
    public int swordDamage = 1;
    public int fireBallDamage = 1;

    // Use this for initialization

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Sword") && (other.tag != "Player"))
        {
            health -= swordDamage;
        }
        if (other.gameObject.CompareTag("Fireball") && (other.tag != "Player"))
        {
            health -= fireBallDamage;
        }

    }
    void Die()
    {
        Destroy(gameObject);
    }
    void Update()
    {
        if (health <= 0)
        {
            
            Die();

        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "ColHealth")
        {
            Destroy(other.gameObject);
            health++;
        }
    }

}
