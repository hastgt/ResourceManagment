using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factory : BaseFactory
{
    [SerializeField] private InventoryDisplay inventoryDisplay;

    private Inventory inventory;
    public Inventory Inventory
    {
        get { return inventory; }
        set
        {
            inventory = value;
            inventoryDisplay.UpdateUI(inventory);
        }
    }

    private void Awake()
    {
        inventory = new Inventory();
    }

    private void Start()
    {
        Inventory.AddResources(new Resource { resourceType = Resource.ResourceType.Wheat, Amount = 1 });
        inventoryDisplay.UpdateUI(inventory);
    }

    protected override void TimeToCraft()
    {
        
    }

}
