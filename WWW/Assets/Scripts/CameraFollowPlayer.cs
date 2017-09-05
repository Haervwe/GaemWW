using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CameraFollowPlayer : MonoBehaviour {

    GameObject player;
    public bool followPlayer = true;

	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
       
        
            player = GameObject.FindGameObjectWithTag("Player");
            Vector3 newPos = new Vector3(player.transform.position.x, player.transform.position.y, this.transform.position.z);//x,y del jugador, z de la camara
            this.transform.position = newPos;
        
        
	}
}
