using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourceView : MonoBehaviour
{
    [SerializeField] private ResourceSprites resourceSprites;
    [SerializeField] private Transform resourceSlotContainer;
    [SerializeField] private Transform resourceSlotTemp;

    public void Initialized(List<Resource> resource)
    {
        foreach (var item in resource)
        {
            Image temp = Instantiate(resourceSlotTemp, resourceSlotContainer).GetComponentInChildren<Image>();
            temp.gameObject.SetActive(true);
            
            switch (item.resourceType)
            {
                case Resource.ResourceType.Wheat:
                    temp.sprite = resourceSprites.WheatSprite;
                    temp.name = $"{ resourceSprites.WheatSprite}";
                    break;
                case Resource.ResourceType.Flour:
                    temp.sprite = resourceSprites.FlourSprite;
                    temp.name = $"{ resourceSprites.FlourSprite}";
                    break;
                case Resource.ResourceType.Bread:
                    temp.sprite = resourceSprites.BreadSprite;
                    temp.name = $"{ resourceSprites.BreadSprite}";
                    break;
                default:
                    Debug.LogError("No item was found");
                    break;
            }
        }
    }
}
