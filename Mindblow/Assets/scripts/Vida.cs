using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Vida : MonoBehaviour {

    public GameObject jugador;
    public Transform transformJugador;

    public GameObject enemigo;
    public Transform transformEnemigo;
    public GameObject enemigo2;
    public Transform transformEnemigo2;
    public GameObject enemigo3;
    public Transform transformEnemigo3;
    public GameObject enemigo4;
    public Transform transformEnemigo4;
    public GameObject enemigo5;
    public Transform transformEnemigo5;
    public GameObject enemigo6;
    public Transform transformEnemigo6;
    public GameObject enemigo7;
    public Transform transformEnemigo7;

    public GameObject enemyBall;
    public Transform transformEnemyBall;
    public GameObject enemyBall2;
    public Transform transformEnemyBall2;
    public GameObject enemyBall3;
    public Transform transformEnemyBall3;


    public GameObject pinchos;
    public Transform transformPinchos;
    public GameObject pinchos2;
    public Transform transformPinchos2;



    public string nombnreEscena;
    public Image vida;
    public float numVida;

    private void Awake()
    {
        jugador = GameObject.FindGameObjectWithTag("Player");
        transformJugador = jugador.transform;


        enemigo = GameObject.FindGameObjectWithTag("Enemigo");
        transformEnemigo = enemigo.transform;
        enemigo2 = GameObject.FindGameObjectWithTag("Enemigo 2");
        transformEnemigo2 = enemigo2.transform;
        enemigo3 = GameObject.FindGameObjectWithTag("Enemigo 3");
        transformEnemigo3 = enemigo3.transform;
        enemigo4 = GameObject.FindGameObjectWithTag("Enemigo 4");
        transformEnemigo4 = enemigo4.transform;
        enemigo5 = GameObject.FindGameObjectWithTag("Enemigo 5");
        transformEnemigo5 = enemigo5.transform;
        enemigo6 = GameObject.FindGameObjectWithTag("Enemigo 6");
        transformEnemigo6 = enemigo6.transform;
        enemigo7 = GameObject.FindGameObjectWithTag("Enemigo 7");
        transformEnemigo7 = enemigo7.transform;

        pinchos = GameObject.FindGameObjectWithTag("Elemento Nocivo");
        transformPinchos = pinchos.transform;
        pinchos2 = GameObject.FindGameObjectWithTag("Elemento Nocivo 2");
        transformPinchos2 = pinchos2.transform;


    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        enemyBall = GameObject.FindGameObjectWithTag("Enemy Ball");
        transformEnemyBall = enemyBall.transform;
        enemyBall2 = GameObject.FindGameObjectWithTag("Enemy Ball 2");
        transformEnemyBall2 = enemyBall2.transform;
        enemyBall3 = GameObject.FindGameObjectWithTag("Enemy Ball 3");
        transformEnemyBall3 = enemyBall3.transform;
    }

    private void FixedUpdate()
    {
        if (numVida < 1)
        {
            cambiarEscena(nombnreEscena);
        }

        if (((Mathf.Abs(transformJugador.localPosition.x - transformEnemigo.localPosition.x) <= 1.1 || Mathf.Abs(transformEnemigo.localPosition.x - transformJugador.localPosition.x) <= 1.1) && (Mathf.Abs(transformJugador.localPosition.y - transformEnemigo.localPosition.y) <= 1.1)) ||
           ((Mathf.Abs(transformEnemigo2.localPosition.x - transformJugador.localPosition.x) <= 1.1) && (Mathf.Abs(transformJugador.localPosition.y - transformEnemigo2.localPosition.y) <= 1.1)) ||
           ((Mathf.Abs(transformEnemigo3.localPosition.x - transformJugador.localPosition.x) <= 1.1) && (Mathf.Abs(transformJugador.localPosition.y - transformEnemigo3.localPosition.y) <= 1.1)) ||
           ((Mathf.Abs(transformEnemigo4.localPosition.x - transformJugador.localPosition.x) <= 1.1) && (Mathf.Abs(transformJugador.localPosition.y - transformEnemigo4.localPosition.y) <= 1.1)) ||
           ((Mathf.Abs(transformEnemigo5.localPosition.x - transformJugador.localPosition.x) <= 1.1) && (Mathf.Abs(transformJugador.localPosition.y - transformEnemigo5.localPosition.y) <= 1.1)) ||
           ((Mathf.Abs(transformEnemigo6.localPosition.x - transformJugador.localPosition.x) <= 1.1) && (Mathf.Abs(transformJugador.localPosition.y - transformEnemigo6.localPosition.y) <= 1.1)) ||
           ((Mathf.Abs(transformEnemigo7.localPosition.x - transformJugador.localPosition.x) <= 1.1) && (Mathf.Abs(transformJugador.localPosition.y - transformEnemigo7.localPosition.y) <= 1.1)) ||

           ((Mathf.Abs(transformEnemyBall.localPosition.x - transformJugador.localPosition.x) <= 1.1) && (Mathf.Abs(transformJugador.localPosition.y - transformEnemyBall.localPosition.y) <= 1.1)) ||
           ((Mathf.Abs(transformEnemyBall2.localPosition.x - transformJugador.localPosition.x) <= 1.1) && (Mathf.Abs(transformJugador.localPosition.y - transformEnemyBall2.localPosition.y) <= 1.1)) ||
           ((Mathf.Abs(transformEnemyBall3.localPosition.x - transformJugador.localPosition.x) <= 1.1) && (Mathf.Abs(transformJugador.localPosition.y - transformEnemyBall3.localPosition.y) <= 1.1)) ||

           ((Mathf.Abs(transformPinchos.localPosition.x - transformJugador.localPosition.x) <= 1.6) && (Mathf.Abs(transformJugador.localPosition.y - transformPinchos.localPosition.y) <= 0.75)) ||
           ((Mathf.Abs(transformPinchos2.localPosition.x - transformJugador.localPosition.x) <= 1.6) && (Mathf.Abs(transformJugador.localPosition.y - transformPinchos2.localPosition.y) <= 0.75))
           )
        {
            numVida -= 2;
            vida.fillAmount = numVida / 100;
        }
    }

    public void cambiarEscena(string nombre)
    {
        SceneManager.LoadScene(nombre);
    }


}
