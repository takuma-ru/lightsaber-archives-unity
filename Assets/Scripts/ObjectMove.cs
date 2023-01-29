using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    [SerializeField] GameObject target;
    [SerializeField] float mouse_sensitivity = 0.1f;
    [SerializeField] float touch_sensitivity = 0.001f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //ドラッグ中もしくはスワイプ中
        if (Input.GetMouseButton(0))
        {
            float dx,dy;

            //PCマウスの場合
            dx = Input.GetAxis("Mouse X") * mouse_sensitivity;
            dy = Input.GetAxis("Mouse Y") * mouse_sensitivity;
            Debug.Log(dy);

            //スマホのタッチの場合
            if (Input.touchCount > 0)
            {
                dx = Input.touches[0].deltaPosition.x * touch_sensitivity;
                dy = Input.touches[0].deltaPosition.y * touch_sensitivity;
            }

            //ドラッグした分だけオブジェクトを動かします。
            target.transform.Translate(dx, 0.0f, dy);
        }
    }
}
