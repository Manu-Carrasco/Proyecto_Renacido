﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Shoot_2 : MonoBehaviour {

    public GameObject Enemy;

    private Transform lados;
    private Rigidbody2D Ball;

    public float BallSpeed;
    public float BallLife;


    void Awake()
    {
        Ball = GetComponent<Rigidbody2D>();
        Enemy = GameObject.FindGameObjectWithTag("Enemigo 6");
        lados = Enemy.transform;
    }

    // Use this for initialization
    void Start()
    {
        if (lados.localScale.x > 0)
        {
            Ball.velocity = new Vector2(BallSpeed, BallSpeed);
            transform.localScale = new Vector3(1, 1, 1);
        }

        else
        {
            Ball.velocity = new Vector2(-BallSpeed, 0);
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, BallLife);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player" || col.gameObject.tag == "Player_Bullet" || col.gameObject.tag == "Player_Sword" || col.gameObject.tag == "Enemigo 4")
        {
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<BoxCollider2D>().enabled = false;
        }
    }

    void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player" || col.gameObject.tag == "Enemigo 4")
        {
            Destroy(gameObject);
        }
    }
}
