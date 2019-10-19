using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemVisual : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Item itemAsset;
    public void Init(Item item)
    {
        itemAsset = item;
        GetComponent<Image>().sprite = item.ItemImage;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        GetComponentInParent<InventoryPanel>().ShowInfo(itemAsset);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        GetComponentInParent<InventoryPanel>().HideInfo(itemAsset);
    }
}
