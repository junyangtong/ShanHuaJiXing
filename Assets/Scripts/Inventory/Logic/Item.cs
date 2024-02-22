using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
   public ItemName itemName;
   public GameObject ToolTip;
   public void ItemClicked()
   {
      //添加到背包并隐藏物体
      InventoryManager.Instance.AddItem(itemName);
      this.gameObject.SetActive(false);
   }
}

