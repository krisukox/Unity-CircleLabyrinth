using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMapScript : MonoBehaviour {
    protected static System.Random ran = new System.Random();
    protected static bool handleObject;
    protected static int index = 0;
    protected static float lastCircleAngle = -1;
    protected static float lastConnectorAngle = -1;
    protected static float deltaHorizontal;
    protected Joystick joystick;

    //protected System.Random ran = new System.Random();

    public static void RestartGame()
    {
        index = 0;
    }

    void Start ()
    {
        joystick = FindObjectOfType<Joystick>();
    }

	void Update ()
    {
        deltaHorizontal = joystick.Horizontal * 2.0f;
    }
}
