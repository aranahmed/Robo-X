using UnityEngine;
using System.Collections;

public class jetpack : MonoBehaviour
{
    public float FlyForce = 40.0f;
    public  int FuelReserve;
    private bool FuelEmpty;

    // Use this for initialization
    void Start()
    {
        //FuelReserve = 100;
        FuelEmpty = false;
    }

    // Update is called once per frame
    void Update()
    {
        bool jetActive = Input.GetButton("Fire1");
        if (jetActive)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, FlyForce));
            FuelReserve -- ;
        }
       
        if (FuelReserve <=0)
        {
            FuelEmpty = true;
        }
        if (FuelEmpty == true)
        {
            jetActive = false;
        }
        if (jetActive == false)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 0));
        }
    }
}