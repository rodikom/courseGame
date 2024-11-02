using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyHealth : MonoBehaviour
{
    private int _maxHP = 10;
    private int _currentHP = 10;

    public int MaxHP { get => _maxHP; }
    public int CurrentHP { get => _currentHP; }

    public event Action<int, int> OnHpChanged;
    public UnityEvent OnDie;

    public void TakeDamage(int damage)
    {
        _currentHP -= damage;
        OnHpChanged?.Invoke(_currentHP, _maxHP);

        if (_currentHP <= 0)
        {
            Debug.Log("Died");
            OnDie?.Invoke();
        }
    }

    private void OnMouseUpAsButton()
    {
        _currentHP--;

        OnHpChanged?.Invoke(_currentHP, _maxHP);

        if (_currentHP <= 0)
        {
            Debug.Log("Died");
            OnDie?.Invoke();
        }
    }
}