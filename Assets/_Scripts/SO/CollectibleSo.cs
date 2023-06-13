using Unity.VisualScripting;
using UnityEngine;
using System;

[CreateAssetMenu(menuName = "SO/Collectible")]
public class CollectibleSo : ScriptableObject
{
    public Action OnValueChanges;

    int _value;
    public int Value {
        set {
            _value = value;
            OnValueChanges?.Invoke();
        }
        get => _value;
    }
}
