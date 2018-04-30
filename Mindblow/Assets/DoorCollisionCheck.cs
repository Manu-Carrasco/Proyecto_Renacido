using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;


public class DoorCollisionCheck : MonoBehaviour
{
    public float xPos1;
    public float yPos1;
    public float xPos2;
    public float yPos2;
    public float xPos3;
    public float yPos3;
    public float xPos4;
    public float yPos4;
    public float xPos5;
    public float yPos5;
    public float xPos6;
    public float yPos6;
    public float xPos7;
    public float yPos7;
    public float xPos8;
    public float yPos8;
    public float xPos9;
    public float yPos9;
    public float xPos10;
    public float yPos10;

    public float xPOS1;
    public float yPOS1;
    public float xPOS2;
    public float yPOS2;

    public float xRED1;
    public float yRED1;
    public float xRED2;
    public float yRED2;

    static bool return1;

    public GameObject Player;
    public Transform TransformPlayer;

    private bool checker = false;

    private void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        // Puerta 1
        if (Input.GetKeyDown(KeyCode.E) && (TransformPlayer.localPosition.x >= xPos1 && TransformPlayer.localPosition.x <= xPos2) && (TransformPlayer.localPosition.y >= yPos1 && TransformPlayer.localPosition.y <= yPos2))
        {
            TransformPlayer.localPosition = new Vector2((float)-75.0, (float)-180.0);
        }

        // Puerta 3
        if (Input.GetKeyDown(KeyCode.E) && (TransformPlayer.localPosition.x >= xPos3 && TransformPlayer.localPosition.x <= xPos4) && (TransformPlayer.localPosition.y >= yPos3 && TransformPlayer.localPosition.y <= yPos4))
        {
            TransformPlayer.localPosition = new Vector2((float)14.5, (float)2.8);
        }

        //Puerta 5 {PUERTA DE ENTRADA A LA 2a HABITACION DEL NIVEL 1}
        //if (Input.GetKeyDown(KeyCode.E) && (TransformPlayer.localPosition.x >= xPos5 && TransformPlayer.localPosition.x <= xPos6) && (TransformPlayer.localPosition.y >= yPos5 && TransformPlayer.localPosition.y <= yPos6))
        //{
        //    TransformPlayer.localPosition = new Vector2((float)-75.0, (float)-160.0);
        //}

        //Puerta 7 {PUERTA DE SALIDA DE LA 2a HABITACION DEL NIVEL 1}
        //if (Input.GetKeyDown(KeyCode.E) && (TransformPlayer.localPosition.x >= xPos7 && TransformPlayer.localPosition.x <= xPos8) && (TransformPlayer.localPosition.y >= yPos7 && TransformPlayer.localPosition.y <= yPos8))
        //{
        //    TransformPlayer.localPosition = new Vector2((float)-75.0, (float)-160.0);
        //}

        //Conexion provisional hasta que se haga la 2a HABITACION DEL NIVEL 1
        if (Input.GetKeyDown(KeyCode.E) && (TransformPlayer.localPosition.x >= xPOS1 && TransformPlayer.localPosition.x <= xPOS2) && (TransformPlayer.localPosition.y >= yPOS1 && TransformPlayer.localPosition.y <= yPOS2))
        {
            TransformPlayer.localPosition = new Vector2((float)37.5, (float)-13.0);
        }

        //Puerta 9
        if (Input.GetKeyDown(KeyCode.E) && (TransformPlayer.localPosition.x >= xPos9 && TransformPlayer.localPosition.x <= xPos10) && (TransformPlayer.localPosition.y >= yPos9 && TransformPlayer.localPosition.y <= yPos10))
        {
            TransformPlayer.localPosition = new Vector2((float)128.9, (float)7.5);
        }

        //Puerta RED
        if (Input.GetKeyDown(KeyCode.E) && (TransformPlayer.localPosition.x >= xRED1 && TransformPlayer.localPosition.x <= xRED2) && (TransformPlayer.localPosition.y >= yRED1 && TransformPlayer.localPosition.y <= yRED2))
        {
            TransformPlayer.localPosition = new Vector2((float)129.3, (float)-4.0);
        }
    }

    //public static DoorCollisionCheck instance = null;

    //public GameObject player;
    //public GameObject puerta1;
    //public GameObject puerta2;
    //public GameObject puerta3;
    //public GameObject puerta4;
    //public GameObject puerta5;
    //public GameObject puerta6;
    //public GameObject puerta7;
    //public GameObject puerta8;
    //public GameObject puerta9;
    //public GameObject puerta10;

    //public int currentDoorNumber;

    //void Awake()
    //{
    //    instance = null;
    //    if (instance == null)
    //    {
    //        DontDestroyOnLoad(gameObject);
    //        instance = this;
    //    }

    //    else if (instance != null)
    //    {
    //        Destroy(gameObject);
    //    }

    //    if (player == null)
    //        player = GameObject.FindGameObjectWithTag("Player");
    //    if (puerta1 == null)
    //        puerta1 = GameObject.FindGameObjectWithTag("Puerta 1");
    //    if (puerta2 == null)
    //        puerta2 = GameObject.FindGameObjectWithTag("Puerta 2");
    //    if (puerta3 == null)
    //        puerta3 = GameObject.FindGameObjectWithTag("Puerta 3");
    //    if (puerta4 == null)
    //        puerta4 = GameObject.FindGameObjectWithTag("Puerta 4");
    //    if (puerta5 == null)
    //        puerta5 = GameObject.FindGameObjectWithTag("Puerta 5");
    //    if (puerta6 == null)
    //        puerta6 = GameObject.FindGameObjectWithTag("Puerta 6");
    //    if (puerta7 == null)
    //        puerta7 = GameObject.FindGameObjectWithTag("Puerta 7");
    //    if (puerta8 == null)
    //        puerta8 = GameObject.FindGameObjectWithTag("Puerta 8");
    //    if (puerta9 == null)
    //        puerta9 = GameObject.FindGameObjectWithTag("Puerta 9");
    //    if (puerta10 == null)
    //        puerta10 = GameObject.FindGameObjectWithTag("Puerta 10");
    //}

    //void OnLevelWasLoaded()
    //{
    //    player = GameObject.FindGameObjectWithTag("Player");

    //    if (puerta1 == null)
    //        puerta1 = GameObject.FindGameObjectWithTag("Puerta 1");
    //    if (puerta2 == null)
    //        puerta2 = GameObject.FindGameObjectWithTag("Puerta 2");
    //    if (puerta3 == null)
    //        puerta3 = GameObject.FindGameObjectWithTag("Puerta 3");
    //    if (puerta4 == null)
    //        puerta4 = GameObject.FindGameObjectWithTag("Puerta 4");
    //    if (puerta5 == null)
    //        puerta5 = GameObject.FindGameObjectWithTag("Puerta 5");
    //    if (puerta6 == null)
    //        puerta6 = GameObject.FindGameObjectWithTag("Puerta 6");
    //    if (puerta7 == null)
    //        puerta7 = GameObject.FindGameObjectWithTag("Puerta 7");
    //    if (puerta8 == null)
    //        puerta8 = GameObject.FindGameObjectWithTag("Puerta 8");
    //    if (puerta9 == null)
    //        puerta9 = GameObject.FindGameObjectWithTag("Puerta 9");
    //    if (puerta10 == null)
    //        puerta10 = GameObject.FindGameObjectWithTag("Puerta 10");

    //    if (puerta1.GetComponent<Door_Info>().doorNumber == 1)
    //    {
    //        player.transform.position = puerta2.transform.position;
    //    }

    //    if (puerta3.GetComponent<Door_Info>().doorNumber == 3)
    //    {
    //        player.transform.position = puerta4.transform.position;
    //    }

    //    if (puerta5.GetComponent<Door_Info>().doorNumber == 5)
    //    {
    //        player.transform.position = puerta6.transform.position;
    //    }

    //    if (puerta7.GetComponent<Door_Info>().doorNumber == 7)
    //    {
    //        player.transform.position = puerta8.transform.position;
    //    }

    //}

    //public void LoadScene (int passedDoorNumber)
    //{
    //    currentDoorNumber = passedDoorNumber;

    //    if (Application.loadedLevel == 1)
    //    {
    //        SceneManager.LoadScene(sceneBuildIndex: 2);
    //    }
    //    else if (Application.loadedLevel == 2)
    //    {
    //        SceneManager.LoadScene(sceneBuildIndex: 1);
    //    }

    //}


}

