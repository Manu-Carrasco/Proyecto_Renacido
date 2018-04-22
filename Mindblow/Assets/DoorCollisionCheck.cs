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

    public GameObject Player;
    public Transform TransformPlayer;

    private bool checker = false;

    private void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && (TransformPlayer.localPosition.x >= xPos1 && TransformPlayer.localPosition.x <= xPos2) && (TransformPlayer.localPosition.y >= yPos1 && TransformPlayer.localPosition.y <= yPos2))
        {
            SceneManager.LoadScene(sceneBuildIndex:2);
        }

        if (Input.GetKeyDown(KeyCode.E) && (TransformPlayer.localPosition.x >= xPos3 && TransformPlayer.localPosition.x <= xPos4) && (TransformPlayer.localPosition.y >= yPos3 && TransformPlayer.localPosition.y <= yPos4))
        {
            TransformPlayer.localPosition = new Vector2((float)32.4, (float)-13.4);
        }

        if (Input.GetKeyDown(KeyCode.E) && (TransformPlayer.localPosition.x >= xPos5 && TransformPlayer.localPosition.x <= xPos6) && (TransformPlayer.localPosition.y >= yPos5 && TransformPlayer.localPosition.y <= yPos6))
        {
            SceneManager.LoadScene(sceneBuildIndex:1);
            TransformPlayer.localPosition = new Vector2((float)14.6, (float)-4.5);
        }
    }
}

