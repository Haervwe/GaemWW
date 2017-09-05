using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackMelee : MonoBehaviour {

    Animator an;
    public string skill = "Attack";
    public string key = "Fire2";
	// Use this for initialization
	void Start () {
        an = GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonUp(key))
        {
            an.SetTrigger("Attack");
        }

	}
}
