using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public string itemName;
    public int damage;
    public float attackSpeed;
    public bool isBroken;

    private void Awake()
    {
        Debug.Log($"�����۸�: {this.itemName}");
        Debug.Log($"���ݷ�: {this.damage}");
        Debug.Log($"���ݼӵ�: {this.attackSpeed}");
        Debug.Log($"�ı�����: {this.isBroken}");
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
}
