using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factory : BaseFactory
{
    [SerializeField] InventoryDisplay inventoryDisplay;

    private Inventory resource;
    
    private void Start()
    {
        resource = new Inventory();
        inventoryDisplay.Inventory = resource;
    }

    protected override void CraftResource()
    {
        Debug.Log("craft resource");
    }

}
