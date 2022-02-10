using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryDisplay : MonoBehaviour
{
    private Inventory _inventory;
    public Inventory Inventory
    {
        get { return _inventory; }
        set
        {
            _inventory = value;
            UpdateUI();
        }
    }

    [SerializeField] private ResourceSprites _resourceSprites;
    [SerializeField] private Transform _resourceSlotContainer;
    [SerializeField] private Transform _resourceSlotTemp;


    private void Update()
    {
        //transform.LookAt(transform.position + Camera.main.transform.rotation * Vector3.forward, Camera.main.transform.rotation * Vector3.up);
    }

    private void UpdateUI()
    {
        foreach (var item in _inventory.Resources)
        {
            RectTransform resourceSlotRectTransform = Instantiate(_resourceSlotTemp, _resourceSlotContainer).GetComponent<RectTransform>();
            resourceSlotRectTransform.gameObject.SetActive(true);

            switch (item.resourceType)
            {
                case Resource.ResourceType.Wheat:
                    resourceSlotRectTransform.gameObject.GetComponentInChildren<Image>().sprite = _resourceSprites._WheatSprite;
                    break;
                case Resource.ResourceType.Flour:
                    resourceSlotRectTransform.gameObject.GetComponentInChildren<Image>().sprite = _resourceSprites._FlourSprite;
                    break;
                case Resource.ResourceType.Bread:
                    resourceSlotRectTransform.gameObject.GetComponentInChildren<Image>().sprite = _resourceSprites._BreadSprite;
                    break;
                default:
                    Debug.LogError("No item was found");
                    break;
            }
        }
    }
}
