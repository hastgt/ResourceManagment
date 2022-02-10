using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryDisplay : MonoBehaviour
{
    private Inventory inventory;
    public Inventory Inventory
    {
        get { return inventory; }
        set
        {
            inventory = value;
            UpdateUI();
        }
    }

    [SerializeField] private ResourceView resourceView;

    private void Update()
    {
        //transform.LookAt(transform.position + Camera.main.transform.rotation * Vector3.forward, Camera.main.transform.rotation * Vector3.up);
    }

    private void UpdateUI()
    {
        resourceView.Initialized(Inventory.Resources);
    }
}
