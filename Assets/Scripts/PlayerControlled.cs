namespace SOGameDev.Demo
{
    using UnityEngine;
    using UnityEngine.Assertions;

    /// <summary>
    ///     Allows the player to control this game object with the horizontal and vertical axis.
    /// </summary>
    [RequireComponent(typeof(Rigidbody2D))]
    public class PlayerControlled : MonoBehaviour
    {
        /// <summary>
        ///     The speed that the character should move at.
        /// </summary>
        public float speed = 0.15f;

        private Rigidbody2D rb;

        private Vector2 heading;

        private void Start()
        {
            rb = GetComponent<Rigidbody2D>();
            Assert.IsNotNull(rb, "PlayerControlled requires a Rigidbody2D component, but none was found.");
        }

        private void FixedUpdate()
        {
            rb.AddForce(speed*heading, ForceMode2D.Impulse);
        }

        private void Update()
        {
            heading = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
        }
    }
}