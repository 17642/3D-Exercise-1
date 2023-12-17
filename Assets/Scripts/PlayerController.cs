using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 50.0f;
    public float horizontalInput;
    public float verticalInput;
    public float turnspeed=1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        //차량을 앞으로 이동
        transform.Translate(Vector3.forward*Time.deltaTime*speed*verticalInput);//0,0,1과 같음
        //transform.Translate(Vector3.right * Time.deltaTime * turnspeed*horizontalInput);//이렇게 하면 좌/우 입력 시 방향 전환 대신 좌우로 이동한다.
        transform.Rotate(Vector3.up*Time.deltaTime * turnspeed * horizontalInput);//물체의 좌우 회전 기준은 Vector의 up
    }
}
