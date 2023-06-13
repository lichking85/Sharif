using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public static Cube Instance;
    
    [SerializeField] float speed;
    [SerializeField] Rigidbody rb;
    [SerializeField] CollectibleSo collectibleSo;

    Vector3 _currentDirection;
    void Awake() {
        if (Instance == null) {
            Instance = this;
        }
    }

    void Start() {
        InputManager.Instance.InputAction += Move;
    }

    void Move(Vector3 dir) {
        _currentDirection = dir;
        rb.velocity = dir * speed ;
    }

    void OnCollisionEnter(Collision collision) {
        switch (collision.collider.tag) {
            case "Lose":
                Lose();
                break;
            case "Bounce":
                Bounce();
                break;
        }
    }

    void OnTriggerEnter(Collider other) {
        other.gameObject.SetActive(false);
        collectibleSo.Value++;
    }

    void Lose() {
        Spawner.Instance.Spawn();        
    }
    void Bounce() {
        Move(-_currentDirection);
    }
}
