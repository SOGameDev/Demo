using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlled : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        //Debug.Log(direction);
        transform.position = transform.position + speed*(new Vector3(horizontal, vertical, 0));
    }
}
