using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPosition : MonoBehaviour
{
    private Vector3 Init_Position; // 初期位置

    // Start is called before the first frame update
    void Start()
    {
        // 初期位置取得
        Init_Position = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
    }

    // 初期化関数
    public void Reset()
    {
        gameObject.transform.position = Init_Position; // 位置の初期化
    }

}
