using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourceView : MonoBehaviour
{
    [SerializeField] private ResourceSprites resourceSprites;
    [SerializeField] private Transform resourceSlotContainer;
    [SerializeField] private Transform resourceSlotTemp;

    [SerializeField] private Image image;


    public void Initialized(List<Resource> resource)
    {
        foreach (var item in resource)
        {
            var temp = Instantiate(resourceSlotTemp, resourceSlotContainer);
            temp.gameObject.SetActive(true);

            switch (item.resourceType)
            {
                case Resource.ResourceType.Wheat:
                    image.sprite = resourceSprites._WheatSprite;
                    break;
                case Resource.ResourceType.Flour:
                    image.sprite = resourceSprites._FlourSprite;
                    break;
                case Resource.ResourceType.Bread:
                    image.sprite = resourceSprites._BreadSprite;
                    break;
                default:
                    Debug.LogError("No item was found");
                    break;
            }
        }
    }
}
