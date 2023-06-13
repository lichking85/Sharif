using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTarget : MonoBehaviour
{
    Transform myTransform;

    void Start() {
        myTransform = transform;
    }

    void Update() {
        var myPosition = myTransform.position;
        var targetPos = new Vector3(myPosition.x, Cube.Instance.transform.position.y, myPosition.z);
        myPosition = targetPos;
        myTransform.position = myPosition;
    }
}
