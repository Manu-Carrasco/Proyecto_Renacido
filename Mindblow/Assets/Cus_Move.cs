using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cus_Move : MonoBehaviour {

    public Rigidbody2D Cursa;

	// Use this for initialization
	void Start () {
        Cursa = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(3, 0));
    }
}
