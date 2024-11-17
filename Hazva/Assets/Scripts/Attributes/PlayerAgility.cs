using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAgility : MonoBehaviour
{
    private int _currentAgility = 1;
    private int _maxAgility = 10;

    public int Agility { get => _currentAgility; }
    public int MaxAgility { get => _maxAgility; }
    
    public void IncreaseAgility(int amount)
    {
        _currentAgility += amount;
        if (_currentAgility > _maxAgility)
        {
            _currentAgility = _maxAgility;
        }
    }
}
