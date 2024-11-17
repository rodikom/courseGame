using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIntelligence : MonoBehaviour
{
    private int _currentIntelligence = 1;
    private int _maxIntelligence = 10;

    public int Intelligence { get => _currentIntelligence; }
    public int MaxIntelligence { get => _maxIntelligence; }
    
    public void IncreaseIntelligence(int amount)
    {
        _currentIntelligence += amount;
        if (_currentIntelligence > _maxIntelligence)
        {
            _currentIntelligence = _maxIntelligence;
        }
    }
}
