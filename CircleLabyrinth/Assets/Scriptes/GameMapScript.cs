using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMapScript : MonoBehaviour {
    private static int startIndex = 6;

    private float lastTouchX;
    
    protected static System.Random ran = new System.Random();
    protected static bool handleObject;
    protected static int index;
    protected static float lastCircleAngle = -1;
    protected static float lastConnectorAngle = -1;
    protected static float deltaHorizontal;
    protected Joystick joystick;

    public static void RestartGame()
    {
        startIndex--;
    }

    public static void NextLevel()
    {
        startIndex--;
    }

    void Start ()
    {
        index = startIndex;
        handleObject = false;
        joystick = FindObjectOfType<Joystick>();
    }

	void Update ()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                lastTouchX = touch.position.x;
            }
            else if (touch.phase == TouchPhase.Moved)
            {
                deltaHorizontal = touch.position.x - lastTouchX;
                deltaHorizontal /= -4;
                lastTouchX = touch.position.x;
            }
        }
        else
            deltaHorizontal = 0;
        //deltaHorizontal = joystick.Horizontal * 2.0f;
    }
}
