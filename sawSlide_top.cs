using UnityEngine;
using System.Collections;

public class sawSlide_top : MonoBehaviour {
   
    private int horzSpeed;
    private int vertSpeed;
    public bool edge;
    public GameObject leftcheck;
    public GameObject rightcheck;

    // Use this for initialization
    void Start () {
        horzSpeed = 5;
        vertSpeed = 5;
	}

    // Update is called once per frame
    void Update() {
        // the saw moves to the right at horzSpeed
        transform.Translate(new Vector2(horzSpeed, 0) * Time.deltaTime);

        if (edge)
        {
            if (transform.position.x <= rightcheck.transform.position.x)
            {
                horzSpeed = -horzSpeed;
                edge = !edge;
            }
        }

        if (!edge)
        {
            if (transform.position.x >= leftcheck.transform.position.x)
            {
                horzSpeed = -horzSpeed;
                edge = !edge;
            }
        }


        
    }

    //void OnCollisionEnter2D(Collision2D coll)
    //{
    //    // if the saw collides with any object with the tag rightcheck it will go to -horzSpeed
    //  if (coll.gameObject.tag == "rightcheck")
    //    {
    //        transform.Translate(new Vector2(-horzSpeed, 0) * Time.deltaTime);
    //        horzSpeed = -horzSpeed;
    //        print("hello");
            
    //    }
    //          //  void update
    //          //  check childrens position then when u reach one you reverse a boolean and also change speed same time
    //          //  
    //}
}
