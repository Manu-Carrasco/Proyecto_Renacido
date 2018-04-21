using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seguimiento_jugador : MonoBehaviour {

    public GameObject camara;
    public Transform transformCamara;
    public GameObject jugador;
    public Transform transformJugador;

    private void Awake()
    {
        camara = GameObject.FindGameObjectWithTag("MainCamera");
        transformCamara = camara.transform;
        jugador = GameObject.FindGameObjectWithTag("Player");
        transformJugador = jugador.transform;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate()
    {
        transformCamara.localPosition = new Vector3(transformJugador.localPosition.x, transformJugador.localPosition.y + (float)3.67, -10);
    }
}
