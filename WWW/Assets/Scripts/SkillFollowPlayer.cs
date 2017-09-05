using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SkillFollowPlayer : MonoBehaviour {

    GameObject player;
    public bool followPlayer = true;
    public float offsetY = 0f;
    public float offsetX = 0f;
    Camera cam;
    Transform my;
    Rigidbody2D body;



    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        cam = Camera.main;
        my = GetComponent<Transform>();
        body = GetComponent<Rigidbody2D>();



    }


    // Update is called once per frame
    void Update()
    {
       
            // Distance from camera to object.  We need this to get the proper calculation.
            float camDis = cam.transform.position.y - my.position.y;

            // Get the mouse position in world space. Using camDis for the Z axis.
            Vector3 mouse = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, camDis));

            float AngleRad = Mathf.Atan2(mouse.y - my.position.y, mouse.x - my.position.x);
            float angle = (180 / Mathf.PI) * AngleRad;

            body.rotation = angle - 90;


            Vector3 newPos = new Vector3(player.transform.position.x + offsetX, player.transform.position.y + offsetY, 0);//x,y del jugador, z de la camara

            this.transform.position = newPos;
        
        
    }   
}

