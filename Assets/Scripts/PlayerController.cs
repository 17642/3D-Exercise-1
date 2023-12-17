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
        //������ ������ �̵�
        transform.Translate(Vector3.forward*Time.deltaTime*speed*verticalInput);//0,0,1�� ����
        //transform.Translate(Vector3.right * Time.deltaTime * turnspeed*horizontalInput);//�̷��� �ϸ� ��/�� �Է� �� ���� ��ȯ ��� �¿�� �̵��Ѵ�.
        transform.Rotate(Vector3.up*Time.deltaTime * turnspeed * horizontalInput);//��ü�� �¿� ȸ�� ������ Vector�� up
    }
}
