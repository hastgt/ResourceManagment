using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resource
{
    public enum ResourceType
    {
        Wheat,
        Flour,
        Bread
    }

    public ResourceType resourceType;

    private int amount;
    public int Amount { get { return amount; } set { amount = value; } }
}
