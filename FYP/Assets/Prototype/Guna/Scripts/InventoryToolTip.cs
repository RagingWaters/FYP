using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryToolTip : MonoBehaviour
{
    [SerializeField] Text ItemNameText;
    
    public void ShowToolTip(Item item)
    {
        ItemNameText.text = item.name;
        gameObject.SetActive(true);
    }
}
