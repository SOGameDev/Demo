namespace SOGameDev.Demo
{
    using UnityEngine;
    using UnityEngine.Assertions;

    /// <summary>
    ///     Allows the player to control this game object with the horizontal and vertical axis.
    /// </summary>
    public class PlayerControlled : MonoBehaviour
    {
        /// <summary>
        ///     The speed that the character should move at.
        /// </summary>
        public float speed = 0.15f;

        private Rigidbody2D rb;

        private void Start()
        {
            rb = GetComponent<Rigidbody2D>();
            Assert.IsNotNull(rb, "PlayerControlled requires a Rigidbody2D component, but none was found.");
        }

        private void FixedUpdate()
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");
            rb.AddForce(speed*(new Vector2(horizontal, vertical)), ForceMode2D.Impulse);
        }
    }
}