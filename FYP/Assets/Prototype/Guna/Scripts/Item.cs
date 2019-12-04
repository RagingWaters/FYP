
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject
{
    new public string name = "New Item";
    public Sprite icon = null;
    public bool isDefaultItem = false;
    public GameObject prefabToSpawn;

    [HideInInspector]
    public GameObject prompt;

    Inventory inv;

    public virtual void Use(Transform t)
    {
        GameObject g = Instantiate(prefabToSpawn, t.position, Quaternion.identity);
        g.GetComponent<prompt>().promptopt = prompt;
        //Destroy(g.GetComponent<ItemPickup>());
        Inventory.instance.Remove(this);

        Debug.Log("Using" + name);
    }
}
