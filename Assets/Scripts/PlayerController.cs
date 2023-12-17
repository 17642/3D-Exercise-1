using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 50.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //차량을 앞으로 이동
        transform.Translate(Vector3.forward*Time.deltaTime*speed);//0,0,1과 같음
    }
}
