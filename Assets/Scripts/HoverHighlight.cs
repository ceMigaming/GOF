using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class HoverHighlight : MonoBehaviour
{
    
    [SerializeField]
    Image cursorImage;
    [SerializeField]
    Sprite hoverSprite;
    [SerializeField]
    Sprite defaultSprite;

    void OnMouseEnter()
    {
        cursorImage.sprite = hoverSprite;
    }

    void OnMouseExit()
    {
        cursorImage.sprite = defaultSprite;
    }
}
