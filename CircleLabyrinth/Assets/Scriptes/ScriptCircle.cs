using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptCircle : GameMapScript {
    private const bool objectType = false;
    private float angle = 0;
    private Rigidbody2D rb2d;
    private bool generated = false;

    public int indexInCircle;
    void Start ()
    {
        rb2d = GetComponent<Rigidbody2D>();
        generated = false;
        rb2d.gameObject.SetActive(true);
    }

	void Update ()
    {
        if (index == indexInCircle && objectType == handleObject)
        {
            generated = true;
            if (lastCircleAngle == -1)
            {
                angle = ran.Next(0, 360);
            }
            else
            {
                angle = ran.Next(0, 304);
                if(lastCircleAngle < lastConnectorAngle)
                {
                    if (angle >= lastCircleAngle - 14)
                    {
                        angle += 28;
                    }
                    if(angle >= lastConnectorAngle - 14)
                    {
                        angle += 28;
                    }
                }
                else
                {
                    if (angle >= lastConnectorAngle - 14)
                    {
                        angle += 28;
                    }
                    if (angle >= lastCircleAngle - 14)
                    {
                        angle += 28;
                    }
                }
                if (angle + 360 <= lastCircleAngle + 14 && angle + 360 >= lastCircleAngle)//
                {
                    angle += 28;
                    if (angle >= lastConnectorAngle - 14)
                        angle += 28;
                }
                if (angle + 360 <= lastConnectorAngle + 14 && angle + 360 >= lastConnectorAngle)
                {
                    angle += 28;
                    if (angle >= lastCircleAngle - 14)
                        angle += 28;
                }
            }
            lastCircleAngle = angle;
            handleObject = true;
        }
        if(index > indexInCircle && generated == false)
            rb2d.gameObject.SetActive(false);
        angle -= deltaHorizontal;
        if (angle > 360)
            angle -= 360;
        rb2d.MoveRotation(angle);
        //Debug.Log(angle);
    }
}
