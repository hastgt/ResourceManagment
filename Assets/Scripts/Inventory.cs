using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Inventory
{
    private List<Resource> _resource;
    public List<Resource> Resources 
    { 
        get { return _resource; }
        set { _resource = value; } 
    }

    public Inventory()
    {
        _resource = new List<Resource>();

        AddResources(new Resource { resourceType = Resource.ResourceType.Wheat, Amount = 1 });
        AddResources(new Resource { resourceType = Resource.ResourceType.Bread, Amount = 1 });
        AddResources(new Resource { resourceType = Resource.ResourceType.Flour, Amount = 1 });

    }

    public void AddResources(Resource resource)
    {
        _resource.Add(resource);
    }
}
