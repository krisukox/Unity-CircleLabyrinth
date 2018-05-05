using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMapScript : MonoBehaviour {
    private static int startIndex = 6;
    
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
        index = --startIndex;
    }

    void Start ()
    {
        index = startIndex;
        handleObject = false;
        joystick = FindObjectOfType<Joystick>();
    }

	void Update ()
    {
        deltaHorizontal = joystick.Horizontal * 2.0f;
    }
}
