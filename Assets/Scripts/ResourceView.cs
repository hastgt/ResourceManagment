using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourceView : MonoBehaviour
{
    [SerializeField] private Sprite WheatSprite;
    [SerializeField] private Sprite FlourSprite;
    [SerializeField] private Sprite BreadSprite;

    [SerializeField] private Transform resourceSlotContainer;
    [SerializeField] private Transform resourceSlotTemp;

    public void Initialized(List<Resource> resource)
    {
        foreach (var item in resource)
        {
            ResourceGameObject tempSprite = Instantiate(resourceSlotTemp, resourceSlotContainer).GetComponentInChildren<ResourceGameObject>();

            tempSprite.gameObject.SetActive(true);
            
            switch (item.resourceType)
            {
                case Resource.ResourceType.Wheat:
                    tempSprite.ResourceSprite.sprite = WheatSprite;
                    tempSprite.name = $"{ WheatSprite}";
                    break;
                case Resource.ResourceType.Flour:
                    tempSprite.ResourceSprite.sprite = FlourSprite;
                    tempSprite.name = $"{ FlourSprite}";
                    break;
                case Resource.ResourceType.Bread:
                    tempSprite.ResourceSprite.sprite = BreadSprite;
                    tempSprite.name = $"{ BreadSprite}";
                    break;
                default:
                    Debug.LogError("No item was found");
                    break;
            }
        }
    }
}
