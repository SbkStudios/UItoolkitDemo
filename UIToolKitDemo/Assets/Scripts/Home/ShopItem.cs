using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Assets/Resources/GameData/ShopItems/ShopItemData", menuName ="Shop/ShopItem")]
public class ShopItem : ScriptableObject
{
    public string itemName;
    public Sprite icon;
    public float cost;
    public int contentValue;
    public Item_Type itemType;
    public Currency_Type currentType;
}

public enum Currency_Type
{
    GOLD,
    USD,
}

public enum Item_Type
{
    GOLD,
    GEMS,
    CHESTBOX,
}
