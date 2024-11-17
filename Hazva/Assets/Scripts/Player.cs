using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Inventory inventory;

    private void Awake()
    {
        inventory = new Inventory();
    }

    private void Start()
    {
        Item newItem = new Item("Sword", 1, null);
        inventory.AddItem(newItem);
        Debug.Log(inventory.HasItem("Sword"));
    }
}
