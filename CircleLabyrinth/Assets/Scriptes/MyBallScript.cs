using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MyBallScript : MonoBehaviour {

    private Rigidbody2D rb2d;
    private RigidbodyType2D rb2dType;

    // Use this for initialization
    void Start ()
    {
        rb2d = GetComponent<Rigidbody2D>();
        //rb2dType = GetType<rb2d>();
    }
	
    void Update()
    {
        if (Time.timeSinceLevelLoad < 0.4f)
            rb2d.bodyType = RigidbodyType2D.Static;
        else
            rb2d.bodyType = RigidbodyType2D.Dynamic;
    }

	void FixedUpdate()
    {
        if(rb2d.position.y < -5.5)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
