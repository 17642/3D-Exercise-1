using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = new Vector3();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        offset = player.transform.position + new Vector3(0, 5, -7);
        transform.position = offset;
        //transform.position
    }
}
