using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    private void Awake()
    {

    }

    void Start()
    {
        Transform transform =
            this.gameObject.GetComponent<Transform>();

        // Vector3 �� ����ü
        // ����ü�� ��� �ν��Ͻ��� ���� �����ؾ� �Ѵ�.
        // this.transform.position = new Vector3(0, 0, 0);

    }

    void Update()
    {
        this.transform.position += new Vector3(0, 0, 0.01f);
    }
}
