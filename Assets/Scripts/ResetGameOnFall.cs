namespace SOGameDev.Demo
{
    using UnityEngine;
    using UnityEngine.SceneManagement;

    /// <summary>
    ///     Resets the game if the object falls too far below the ground.
    /// </summary>
    public class ResetGameOnFall : MonoBehaviour
    {
        /// <summary>
        ///     The minimum distance below the ground that this object's center
        ///     must be for the game to reset.
        /// </summary>
        public float distance = 2.0f;

        private Transform ground;

        private void Start()
        {
            ground = GameObject.FindWithTag("Ground").transform;
        }

        private void Update()
        {
            if (transform.position.y < ground.position.y - distance)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}