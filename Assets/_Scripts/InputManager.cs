using System;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static InputManager Instance;
    public Action<Vector3> InputAction;

    Vector3 _onTouchPos;
    Vector3 _onReleasePos;

    void Awake() {
        if (Instance == null) {
            Instance = this;
        }
    }
    void Update()
    {
        #region Key Board Input
        if (Input.GetKeyDown(KeyCode.RightArrow)) {
            InputAction?.Invoke(Vector3.right);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            InputAction?.Invoke(Vector3.left);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            InputAction?.Invoke(Vector3.up);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow)) {
            InputAction?.Invoke(Vector3.down);
        }
        #endregion
        #region Mouse And Touch Input
        if (Input.GetMouseButtonDown(0)) {
            _onTouchPos = Input.mousePosition;
        }
        if (Input.GetMouseButtonUp(0)) {
            _onReleasePos = Input.mousePosition;

            var deltaPos = _onReleasePos - _onTouchPos;
            if (Mathf.Abs(deltaPos.x) >= Mathf.Abs(deltaPos.y)) {
                if (deltaPos.x > 0) {
                    InputAction?.Invoke(Vector3.right);
                }
                else {
                    InputAction?.Invoke(Vector3.left);
                }
            }
            else {
                if (deltaPos.y >= 0) {
                    InputAction?.Invoke(Vector3.up);
                }
                else {
                    InputAction?.Invoke(Vector3.down);
                }
            }
        }
        #endregion
    }
}
