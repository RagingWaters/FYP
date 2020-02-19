using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryToolTip : MonoBehaviour
{
    [SerializeField] Text ItemNameText;
    [SerializeField] Text ItemDescriptionText;

    public void ShowToolTip(Item item)
    {
        ItemNameText.text = item.name;
        gameObject.SetActive(true);

        ItemDescriptionText.text = item.description;
        gameObject.SetActive(true);
    }

    public void CloseToolTip()
    {
        gameObject.SetActive(false);
    }
}
