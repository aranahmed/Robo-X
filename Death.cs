using UnityEngine;
using System.Collections;

public class Death : MonoBehaviour {
    //public GameObject Player;
    //public GameObject Saw;
    //public GameObject Spawn;
    Vector3 spawnPoint;
    

	// Use this for initialization
	void Start () {
        spawnPoint = this.transform.position;
	}


    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "InstaDeath")
        {
            transform.position = spawnPoint;

            //AudioSource.PlayClipAtPoint(death, transform.position);
        }
    }

	// Update is called once per frame
	void Update () {
	
	}
}
