using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEditor.Timeline.Actions;
using UnityEngine;

public class Inventory
{
    public List<Item> items = new List<Item>();

    public void AddItem(Item item)
    {
        items.Add(item);
    }

    public void RemoveItem(Item item)
    {
        items.Remove(item);
    }

    public void RemoveItem(string itemName)
    {
        Item item = items.Find(i => i.name == itemName);
        if (item != null)
        {
            items.Remove(item);
        }
    }

    public bool HasItem(string itemName)
    {
        return items.Exists(i => i.name == itemName);
    }

    public Item GetItem(string itemName)
    {
        return items.Find(i => i.name == itemName);
    }
    
}