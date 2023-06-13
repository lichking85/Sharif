using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField] Transform cameraTarget;
    void LateUpdate() {
        transform.position = cameraTarget.position;
    }
}
