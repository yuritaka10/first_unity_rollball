using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    Rigidbody rb;
    public float speed;
    //  float <- cal shousu-ten

    // Start is called before the first frame update
    void Start()
    {
        //Startメソッドは最初に一回だけ実行する
        // Debug.Log("Hello,World!");
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //一秒間に数十回のスピーどで実行を繰り返す
        float moveH = Input.GetAxis("Horizontal");
        float moveV = Input.GetAxis("Vertical");
        
        Vector3 move = new Vector3(moveH, 0, moveV);
        //Vector3型の変数Moveを定義。Vector３は３つの小数点の値を入れられる(x,y,z)
        rb.AddForce(move * speed);
    }
}
