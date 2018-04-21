using UnityEngine;
using UnityEngine.SceneManagement;



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

    public GameObject Player;
    public Transform TransformPlayer;

    private void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && (TransformPlayer.localPosition.x >= xPos1 && TransformPlayer.localPosition.x <= xPos2) && (TransformPlayer.localPosition.y >= yPos1 && TransformPlayer.localPosition.y <= yPos2))
        {
            TransformPlayer.localPosition = new Vector3((float)20.0, (float)-22.5, TransformPlayer.localPosition.z);
        }
        if (Input.GetKeyDown(KeyCode.E) && (TransformPlayer.localPosition.x >= xPos3 && TransformPlayer.localPosition.x <= xPos4) && (TransformPlayer.localPosition.y >= yPos3 && TransformPlayer.localPosition.y <= yPos4))
        {
            TransformPlayer.localPosition = new Vector3((float)-33.4, (float)-22.5, TransformPlayer.localPosition.z);
        }
    }
}

