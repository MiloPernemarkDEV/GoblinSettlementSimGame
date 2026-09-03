using System;
using System.Collections.Generic;
using UnityEngine;

public class Blackboard : MonoBehaviour
{
    private Dictionary<string, IBlackboardKey> keys = new Dictionary<string, IBlackboardKey>();

    public void AddKey<T>(string name, T defaultValue = default)
    {
        if (!keys.ContainsKey(name))
        {
            keys.Add(name, new BlackboardKey<T>(defaultValue));
        }
    }

    public T GetValue<T>(string name)
    {
        if (keys.TryGetValue(name, out var key) && key is BlackboardKey<T> typedKey)
        {
            return typedKey.Value;
        }
        
        return default; 
    }

    public void SetValue<T>(string name, T value)
    {
        if (keys.TryGetValue(name, out var key) && key is BlackboardKey<T> typedKey)
        {
            typedKey.Value = value;
        }
    }
}