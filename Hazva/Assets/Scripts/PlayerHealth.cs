using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerHealth : MonoBehaviour
{
    private int _maxHP = 3;
    private int _currentHP = 3;

    public int MaxHP { get => _maxHP; }
    public int CurrentHP { get => _currentHP; }
    public event Action<int, int> OnHpChanged;
    public UnityEvent OnDie;

    public List<GameObject> enemies;

    private void Awake()
    {
        enemies = new List<GameObject>(GameObject.FindGameObjectsWithTag("Enemy"));
    }
    
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (enemies.Contains(collision.gameObject))
        {
            Debug.Log("Hit");
            OnCollideWithEnemy();
        }
    }

    private void OnCollideWithEnemy()
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