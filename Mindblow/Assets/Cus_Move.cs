using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cus_Move : MonoBehaviour {

    public Rigidbody2D Cursa;
    public GameObject Curs;
    public Transform transoformCurs;
    public GameObject player;
    public Transform transoformPlayer;


	// Use this for initialization
	void Start () {
        Cursa = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(transoformPlayer.localPosition.y < -175)
            GetComponent<Rigidbody2D>().AddForce(new Vector2(3, 0));
        else
            GetComponent<Rigidbody2D>().AddForce(new Vector2(-30, 0));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            transoformCurs.localPosition = new Vector2((float)-92.89, (float)-181.69);
        }
            
    }
}
