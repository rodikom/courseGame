using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEditor.Timeline.Actions;
using UnityEngine;

public class Item
{
    public string name;
    public int value;
    public Sprite icon;

    public Item(string name, int value, Sprite icon)
    {
        this.name = name;
        this.value = value;
        this.icon = icon;
    }
}
