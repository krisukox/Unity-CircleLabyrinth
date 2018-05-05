using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.CrossPlatformInput;

public class MapController : MonoBehaviour {

    private Rigidbody2D rb2d;
    private float angle;
    protected Joystick joystick;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        joystick = FindObjectOfType<FixedJoystick>();
    }

	void FixedUpdate()
    {
        //float moveHorizontal = Input.GetAxis("Horizontal");
        //Vector2 moveVec = new Vector2(CrossPlatformInputManager.GetAxis("Horizontal"), CrossPlatformInputManager.GetAxis("Vertical"))
        //float movementHor = CrossPlatformInputManager.GetAxis("Hor");
        angle -= joystick.Horizontal * 2.5f;
        Debug.Log(joystick.Horizontal);
        //angle -= movementHor;
        if (angle >= 360)
        {
            angle -= 360;
        }
        if (angle <= -360)
        {
            angle += 360;
        }
        rb2d.MoveRotation(angle);
        //Debug.Log(angle);
        //rb2d.AddTorque(moveHorizontal);
    }
}
