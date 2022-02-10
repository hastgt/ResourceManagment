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

    private int _amount;
    public int Amount { get { return _amount; } set { _amount = value; } }
}
