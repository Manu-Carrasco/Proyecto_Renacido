using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Position_Enemy_6 : MonoBehaviour {

    public GameObject canonEnemy6;
    public Transform transformCanonEnemy6;

    public GameObject enemy6;
    public Transform transformEnemy6;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transformEnemy6.localScale.x > 0)
        {
            transformCanonEnemy6.localPosition = new Vector3(transformEnemy6.localPosition.x + 1, transformEnemy6.localPosition.y + 0.1f, transformEnemy6.localPosition.z);
        }

        if (transformEnemy6.localScale.x < 0)
        {
            transformCanonEnemy6.localPosition = new Vector3(transformEnemy6.localPosition.x - 1, transformEnemy6.localPosition.y + 0.1f, transformEnemy6.localPosition.z);
        }
    }
}
