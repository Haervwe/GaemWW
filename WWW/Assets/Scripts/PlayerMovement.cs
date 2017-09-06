using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerMovement : NetworkBehaviour {
    public float moveSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (!isLocalPlayer)
        {
            return;
        }


        if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)

        {

            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f), Space.World);


        }


        if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)

        {


            transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime, 0f),Space.World);

        }
      

            //Get the Screen positions of the object
            Vector2 positionOnScreen = Camera.main.WorldToViewportPoint(transform.position);

            //Get the Screen position of the mouse
            Vector2 mouseOnScreen = (Vector2)Camera.main.ScreenToViewportPoint(Input.mousePosition);

            //Get the angle between the points
            float angle = AngleBetweenTwoPoints(positionOnScreen, mouseOnScreen);

            //Ta Daaa
            transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, angle-100));
        }

        float AngleBetweenTwoPoints(Vector3 a, Vector3 b) {
            return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
        }
        
    }

