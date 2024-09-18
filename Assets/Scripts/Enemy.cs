using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public List <DropSystem> itemDrops = new List <DropSystem>();
    // Start is called before the first frame update
    public void DropLoot()
    {
        float chance = Random.Range(0f, 100f);
        for (int i = 0; i < itemDrops.Count; i++)
        {
            if(chance <= itemDrops[i].DropChance)
            {
                int amountToDrop = Random.Range(itemDrops[i].min, itemDrops[i].max);
                for (int j = 0; j < amountToDrop; j++)
                {
                    GameObject ItemSpawn = Instantiate(itemDrops[i].ItemPrefab, transform.position,Quaternion.identity);
                    
                    Destroy (ItemSpawn, itemDrops[i].duration);
                }
                Debug.Log($"{amountToDrop} {itemDrops[i].ItemName}(s) dropped.");
            }
           
        }
    }

    private void OnDestroy()
    {
        DropLoot();
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
