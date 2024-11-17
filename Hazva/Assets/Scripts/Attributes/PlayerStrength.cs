using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStrength : MonoBehaviour
{
    private int _currentStrength = 1;
    private int _maxStrength = 10;

    public int Strength { get => _currentStrength; }
    public int MaxStrength { get => _maxStrength; }
    
    public void IncreaseStrength(int amount)
    {
        _currentStrength += amount;
        if (_currentStrength > _maxStrength)
        {
            _currentStrength = _maxStrength;
        }
    }

}
