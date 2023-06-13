using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    [SerializeField] Text collectibleText;
    [SerializeField] CollectibleSo collectibleSo;

    void Start() {
        collectibleSo.OnValueChanges += UpdateCollectibleText;
    }
    void UpdateCollectibleText() {
        collectibleText.text = collectibleSo.Value.ToString();
    }
}
