using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;



public class PlayerShooting : NetworkBehaviour
{

    public GameObject projectile;
    public float offsetX = 0f;
    public float offsetY = 0f;
    public float visualCd;
    public float cd = 5f;
    public string key;
    public float inventoryAmount = 5f;

    float cdInt = 0;

    // Update is called once per frame
    void Update()
    {
        
            if (Input.GetButtonUp(key) && cdInt <= 0 && inventoryAmount > 0)
            {
                cdInt = cd;

                Vector3 offset = transform.rotation * new Vector3(offsetX, offsetY, 0);
                Instantiate(projectile, transform.position + offset, transform.rotation);
                inventoryAmount -= 1;
            }
        
        cdInt -= Time.time;
        visualCd = cdInt;
    }
}

