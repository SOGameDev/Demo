namespace SOGameDev.Demo
{
    using UnityEngine;

    public class PlayerControlled : MonoBehaviour
    {
        public float speed;

        // Update is called once per frame
        void Update()
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");
            transform.position = transform.position + speed*(new Vector3(horizontal, vertical, 0));
        }
    }
}