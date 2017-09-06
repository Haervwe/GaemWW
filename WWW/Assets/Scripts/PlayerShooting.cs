using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;



public class PlayerShooting : NetworkBehaviour
{

    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public float visualCd;
    public float cd = 5f;
    public string key;
    public float inventoryAmount = 5f;
    float cdInt = 0;
    public float destructionTime = 2f;
    public float bulletSpeed = 3f;


   

    // Update is called once per frame
    void Update()
    {
        if (!isLocalPlayer)
        {
            return;
        }


        if (Input.GetButtonUp(key) && cdInt <= 0 && inventoryAmount > 0)
        {
            cdInt = cd;
            Fire();

        }

        cdInt -= Time.time;
        visualCd = cdInt;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "ColAmmo")
        {
            Destroy(other.gameObject);
            inventoryAmount++;
        }
    }

    void Fire()
    {
        // Create the Bullet from the Bullet Prefab
        var bullet = (GameObject)Instantiate(
            bulletPrefab,
            bulletSpawn.position,
            bulletSpawn.rotation);

        // Add velocity to the bullet
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * bulletSpeed;

        // Destroy the bullet after 2 seconds
        Destroy(bullet, destructionTime);
    }
}

