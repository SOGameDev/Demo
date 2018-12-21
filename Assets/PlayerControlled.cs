namespace SOGameDev.Demo
{
    using UnityEngine;

    /// <summary>
    ///     Allows the player to control this game object with the horizontal and vertical axis.
    /// </summary>
    public class PlayerControlled : MonoBehaviour
    {
        /// <summary>
        ///     The speed that the character should move at.
        /// </summary>
        public float speed = 0.15f;
        
        private void Update()
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");
            transform.position = transform.position + speed*(new Vector3(horizontal, vertical, 0));
        }
    }
}