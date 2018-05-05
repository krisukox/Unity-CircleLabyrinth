using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptConnector : GameMapScript {
    private const bool objectType = true;
    private float angle = 0;
    private Rigidbody2D rb2d;
    private bool generated = false;

    public int indexInCircle;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        generated = false;
    }

    void Update()
    {
        if (indexInCircle == index && objectType == handleObject)
        {
            generated = true;
            angle = ran.Next(0, 338);
            if (angle == 0 && lastCircleAngle == 359)
            {
                angle += 1;
            }
            else if (angle >= lastCircleAngle - 11)
            {
                angle += 22;
            }
            lastConnectorAngle = angle;
            handleObject = false;
            index++;
        }
        if (index > indexInCircle && generated == false)
            rb2d.gameObject.SetActive(false);
        angle -= deltaHorizontal;
        if (angle > 360)
            angle -= 360;
        rb2d.MoveRotation(angle);
    }
}
