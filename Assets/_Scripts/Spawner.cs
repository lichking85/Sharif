using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public static Spawner Instance;

    void Awake() {
        if (Instance == null) {
            Instance = this;
        }
    }

    void Start()
    {
        Spawn();
    }

    public void Spawn() {
        Cube.Instance.transform.position = transform.position;
    }
}
