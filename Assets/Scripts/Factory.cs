using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factory : BaseFactory
{
    [SerializeField] InventoryDisplay _inventoryDisplay;

    private Inventory _resources;
    
    private void Start()
    {
        _resources = new Inventory();
        _inventoryDisplay.Inventory = _resources;
    }

    protected override void CraftResource()
    {
        Debug.Log("craft resource");
    }

}
