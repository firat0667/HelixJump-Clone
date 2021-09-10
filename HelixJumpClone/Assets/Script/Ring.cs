using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ring : MonoBehaviour
{
    public Transform ball;
    private Gamemanager gm;
    void Start()
    {
        gm = GameObject.FindObjectOfType<Gamemanager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y +12f >= ball.position.y)
        {
            Destroy(gameObject);
            gm.GameScore(25);
        }

    }
}
