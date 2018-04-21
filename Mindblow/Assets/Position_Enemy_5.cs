using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Position_Enemy_5 : MonoBehaviour {

    public GameObject canonEnemy5;
    public Transform transformCanonEnemy5;

    public GameObject enemy5;
    public Transform transformEnemy5;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transformEnemy5.localScale.x > 0)
        {
            transformCanonEnemy5.localPosition = new Vector3(transformEnemy5.localPosition.x + 1, transformEnemy5.localPosition.y + 0.1f, transformEnemy5.localPosition.z);
        }

        if (transformEnemy5.localScale.x < 0)
        {
            transformCanonEnemy5.localPosition = new Vector3(transformEnemy5.localPosition.x - 1, transformEnemy5.localPosition.y + 0.1f, transformEnemy5.localPosition.z);
        }
    }
}
