using UnityEngine;
[System.Serializable]

public class DropSystem
{
    public string ItemName;
    public GameObject ItemPrefab;

    [Range(0,100)]
    public float DropChance;

    public int min, max;
    public float duration;
    
}
