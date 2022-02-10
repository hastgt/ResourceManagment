using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Inventory
{
    private List<Resource> resources;
    public List<Resource> Resources 
    { 
        get { return resources; }
        set { resources = value; } 
    }

    public Inventory()
    {
        resources = new List<Resource>();
    }

    public void AddResources(Resource resource)
    {
        this.resources.Add(resource);
    }
}
