using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{

    Animator an;
    public string skill = "Shield";
    public string key = "e";
    public int shieldAmmo = 1;

    // Use this for initialization
    void Start()
    {
        an = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonUp(key))
        {
            an.SetTrigger("Shield");
            shieldAmmo--;
        }

    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "ColShield")
        {
            Destroy(other.gameObject);
            shieldAmmo++;
        }
    }
}

