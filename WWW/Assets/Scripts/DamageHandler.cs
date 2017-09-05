using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageHandler : MonoBehaviour {
    public int health = 1;
    public int swordDamage = 1;
    public int fireBallDamage = 1;

	// Use this for initialization

	void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Sword")){
            health -= swordDamage;
        } 
        if (other.gameObject.CompareTag("Fireball")){
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
    
}
