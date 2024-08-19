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

        // Vector3 는 구조체
        // 구조체는 모든 인스턴스의 값을 변경해야 한다.
        // this.transform.position = new Vector3(0, 0, 0);

    }

    void Update()
    {
        this.transform.position += new Vector3(0, 0, 0.01f);
    }
}
