using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class InventorySlot : MonoBehaviour, ISelectHandler
{
    public Image icon;
    public Button button;
    [SerializeField] InventoryToolTip toolTip;

    Item item;

    protected virtual void OnValidate()
    {
        if(toolTip == null)
        {
            toolTip = FindObjectOfType<InventoryToolTip>();
        }
    }
    
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

    public void OnSelect(BaseEventData eventData)
     {
         // Do something.
         Debug.Log("<color=red>Event:</color> Completed selection.");
         toolTip.ShowToolTip((Item)item);
     }


}
