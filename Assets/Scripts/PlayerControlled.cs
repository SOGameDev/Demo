namespace SOGameDev.Demo
{
    using UnityEngine;
    using UnityEngine.Assertions;

    /// <summary>
    ///     Allows the player to control this game object with the horizontal and vertical axis.
    /// </summary>
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerControlled : MonoBehaviour
    {
        /// <summary>
        ///     The speed that the character should move at.
        /// </summary>
        public float speed = 0.15f;

        private Rigidbody rb;

        private Vector2 heading;
        GameObject bearTrail;

        GameObject bear;

        private void Start()
        {
            rb = GetComponent<Rigidbody>();
            bear = GameObject.Find("BearTrail");
            bearTrail = GameObject.Find("BearTrail");
            Assert.IsNotNull(rb, "PlayerControlled requires a Rigidbody2D component, but none was found.");
        }

        private void FixedUpdate()
        {
            rb.AddForce(speed*heading, ForceMode.Impulse);
        }

        void OnCollisionEnter(Collision coll){
            if(coll.gameObject.name == "Bear"){
                Rigidbody rb = coll.gameObject.GetComponent<Rigidbody>();
                if (rb != null){ rb.AddExplosionForce(1000.0f, coll.gameObject.transform.position, 2.0f, 3.0F); }
            }
        }

        private void Update()
        {
            heading = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
            bearTrail.transform.position = bear.transform.position + new Vector3(0,0,-5);
        }
    }
}