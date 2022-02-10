using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourceGameObject : MonoBehaviour
{
    [field: SerializeField] public SpriteRenderer ResourceSprite { get; private set; }
    [field: SerializeField] public Image BackgroundImage { get; private set; }

    public bool IsReadyToPickUp { get; private set; }
   
}
