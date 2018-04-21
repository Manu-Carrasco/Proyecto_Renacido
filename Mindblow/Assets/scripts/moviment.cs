using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moviment : MonoBehaviour
{
    private bool tocandoElSuelo;
    public GameObject jugador;
    public Transform transformJugador;

    private void Awake()
    {
        jugador = GameObject.FindGameObjectWithTag("Player");
        transformJugador = jugador.transform;
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A)) // ir a la izquierda
        {
            transformJugador.localScale = new Vector3(-1, 1, 1);
            GetComponent<Rigidbody2D>().AddForce(new Vector2(-60, 0));
        }

        if (Input.GetKey(KeyCode.D)) // ir a la derecha
        {
            transformJugador.localScale = new Vector3(1, 1, 1);
            GetComponent<Rigidbody2D>().AddForce(new Vector2(60, 0));
        }

        if (Input.GetKeyDown(KeyCode.W) && tocandoElSuelo) // saltar
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 1800));
            tocandoElSuelo = false;
        }

        /*if (Input.GetKey(KeyCode.LeftArrow)) // disparar izquierda
        {

        }

        if (Input.GetKey(KeyCode.RightArrow)) // disparar derecha
        {

        }*/
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "SUELO")
        {
            tocandoElSuelo = true;
        }
    }
}
