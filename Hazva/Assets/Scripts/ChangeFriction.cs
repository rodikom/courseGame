using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeFriction : MonoBehaviour
{
    public PhysicsMaterial2D playerMaterial; // Матеріал персонажа
    private float originalFriction; // Для збереження початкового значення тертя
    private bool isInTrigger = false; // Для відстеження, чи персонаж у тригері

    private void Start()
    {
        // Зберігаємо початкове значення тертя матеріалу персонажа
        originalFriction = playerMaterial.friction;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerMaterial.friction = 5f;
            isInTrigger = true; // Позначаємо, що персонаж у тригері
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerMaterial.friction = originalFriction;
            isInTrigger = false; // Позначаємо, що персонаж вийшов з тригера
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        // Перевіряємо, що персонаж дійсно в тригері
        if (other.CompareTag("Player") && !isInTrigger)
        {
            playerMaterial.friction = 5f;
            isInTrigger = true;
        }
    }
}

