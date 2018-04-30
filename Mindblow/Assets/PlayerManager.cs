using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour {

	Rigidbody2D player;

	public Transform NAVE;

    float damage = 2;

	// Use this for initialization
	void Start () {
		player = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update () {
        
	}

	void OnCollisionEnter2D(Collision2D col)
	{
        if (col.gameObject.tag == "Enemigo" || col.gameObject.tag == "Enemigo 2" || col.gameObject.tag == "Enemigo 3" || col.gameObject.tag == "Enemigo 4" || col.gameObject.tag == "Enemigo 5" || col.gameObject.tag == "Enemigo 6" || col.gameObject.tag == "Enemigo 7" || col.gameObject.tag == "Elemento Nocivo" || col.gameObject.tag == "Elemento Nocivo 2") //|| col.tag == "OtroEnemigo")
        {
            player.velocity = new Vector2(-25, 25);
            col.gameObject.SendMessage("Damage", damage);
        }

		if(col.gameObject.tag == "Teledirigido") //|| col.tag == "OtroEnemigo")
		{
			player.velocity = new Vector2 (0, 5);
		}

        if (col.gameObject.tag == "Trampolin") //|| col.tag == "OtroEnemigo")
        {
            player.velocity = new Vector2(0, 100);
        }

        if (col.gameObject.tag == "Curs Navet")
        {
            NAVE.localPosition = new Vector2((float)7.0, (float)-3.8);
        }

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemigo" || collision.gameObject.tag == "Enemigo 2" || collision.gameObject.tag == "Enemigo 3" || collision.gameObject.tag == "Enemigo 4" || collision.gameObject.tag == "Enemigo 5" || collision.gameObject.tag == "Enemigo 6" || collision.gameObject.tag == "Enemigo 7" || collision.gameObject.tag == "Elemento Nocivo" || collision.gameObject.tag == "Elemento Nocivo 2") //|| col.tag == "OtroEnemigo")
        {
            collision.SendMessage("Damage", damage);
        }
    }
}
