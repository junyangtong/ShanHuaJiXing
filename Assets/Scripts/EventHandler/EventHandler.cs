using System;
using UnityEngine;

public static class EventHandler
{
    //选择背包中的物品
    public static event Action<ItemDetails>ItemSelectedEvent;
    public static void CallItemSelectedEvent(ItemDetails itemDetails)
    {
        ItemSelectedEvent?.Invoke(itemDetails);
    }
    
}
