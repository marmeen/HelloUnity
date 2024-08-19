using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<GameObject> itemGos;

    private void Awake()
    {

        Debug.Log($"<color=yellow>Inventory Ŭ������ Awake ȣ��... ����: {itemGos.Count}</color>");

        // itemGos�� ��ȸ�ϸ� �����۵��� �̸��� ����ϰ� �ʹ�.
        for (int i = 0; i < this.itemGos.Count; i++)
        {
            Item item = itemGos[i].GetComponent<Item>();
            Debug.Log($"<color=red>{item.itemName}</color>");
        }

        // ���
        // �ܰ�
        // Ȱ
    }

}
