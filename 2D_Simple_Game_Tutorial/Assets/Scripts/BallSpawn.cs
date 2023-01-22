using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawn : MonoBehaviour
{
    public Transform ball;

    void Start()
    {
        InvokeRepeating(nameof(Spawn), 0f, 2f);
    }

    void Spawn()
    {
        Instantiate(ball, new Vector3(Random.Range(-9, 9),6, 0), Quaternion.identity);
    }
}
