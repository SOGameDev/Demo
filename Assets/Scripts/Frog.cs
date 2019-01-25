using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frog : MonoBehaviour
{
    Vector3 m_LeftForce;
    Vector3 m_RightForce;
    public GameObject bear;
    // Start is called before the first frame update
    void Start()
    {
        m_LeftForce = new Vector3(-3.0f, 3.0f, 0.0f);
        m_RightForce = new Vector3(3.0f, 3.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject bearHit = collision.gameObject;
        GameObject bearNew = Instantiate(bear, bearHit.transform.position, Quaternion.identity);
        bearHit.GetComponent<Rigidbody2D>().AddForce(m_LeftForce, ForceMode2D.Impulse);
        bearNew.GetComponent<Rigidbody2D>().AddForce(m_RightForce, ForceMode2D.Impulse);
    }
}
