using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<GameObject> itemGos;

    private void Awake()
    {

        Debug.Log($"<color=yellow>Inventory 클래스의 Awake 호출... 개수: {itemGos.Count}</color>");

        // itemGos를 순회하며 아이템들의 이름을 출력하고 싶다.
        for (int i = 0; i < this.itemGos.Count; i++)
        {
            Item item = itemGos[i].GetComponent<Item>();
            Debug.Log($"<color=red>{item.itemName}</color>");
        }

        // 장검
        // 단검
        // 활
    }

}
