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
        Debug.Log($"아이템명: {this.itemName}");
        Debug.Log($"공격력: {this.damage}");
        Debug.Log($"공격속도: {this.attackSpeed}");
        Debug.Log($"파괴여부: {this.isBroken}");
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
