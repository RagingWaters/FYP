using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    public Image icon;

    Item item;

    public void AddItem (Item newItem)
    {
        item = newItem;

        icon.sprite = item.icon;
        icon.enabled = true;
    }

    public void ClearSlot ()
    {
        item = null;

        icon.sprite = null;
        icon.enabled = false;
    }

    public void UseItem ()
    {
        if (item != null)
        {
            Collider[] colliders = Physics.OverlapSphere(PlayerControls.instance.transform.position, 0.01f);

            foreach(Collider c in colliders)
            {
                UsableItem usableItem = c.GetComponent<UsableItem>();
                
                if (!usableItem)
                {
                    continue;
                }

                foreach (Item i in usableItem.items)
                {
                    if (i == item)
                    {
                        item.Use(c.transform);
                        break;
                    }
                }
            }
            
        }
    }
}
