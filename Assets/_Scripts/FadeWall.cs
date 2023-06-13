using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeWall : MonoBehaviour
{
    [SerializeField] float fadeTime;
    [SerializeField] float activeTime;
    [SerializeField] GameObject wall;
    
    bool _isActive;
    float _timer;
    void Start() {
        _isActive = true;
    }

    void Update() {
        _timer += Time.deltaTime;
        if (_isActive) {
            if (_timer >= activeTime) {
                Deactivate();
            }
        }
        else {
            if (_timer >= fadeTime) {
                Activate();                
            }
        }
    }

    void Deactivate() {
        _timer = 0;
        _isActive = false;
        wall.SetActive(false);
    }
    void Activate() {
        _timer = 0;
        _isActive = true;
        wall.SetActive(true);
    }
}
