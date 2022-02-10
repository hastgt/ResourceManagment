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

        AddResources(new Resource { resourceType = Resource.ResourceType.Wheat, Amount = 1 });
        AddResources(new Resource { resourceType = Resource.ResourceType.Bread, Amount = 1 });
        AddResources(new Resource { resourceType = Resource.ResourceType.Flour, Amount = 1 });

    }

    public void AddResources(Resource resource)
    {
        this.resources.Add(resource);
    }
}
