using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    GameObject frog;

    // Start is called before the first frame update
    void Start()
    {
        frog = GameObject.Find("Frog");
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, new Vector3(

                frog.transform.position.x,
                frog.transform.position.y,
                frog.transform.position.z - 5.0f

        ), Time.deltaTime * 5.0f);

    }
}
