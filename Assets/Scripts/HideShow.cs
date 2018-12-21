namespace SOGameDev.Demo
{
    using UnityEngine;

    /// <summary>
    ///     Toggles this object's active state. This will hide an object if it is visible, and show the object if it is hidden.
    /// </summary>
    public class HideShow : MonoBehaviour
    {
        /// <summary>
        ///     Call this to toggle the active (hidden/shown) state of this object.
        /// </summary>
        public void Toggle()
        {
            gameObject.SetActive(!gameObject.activeSelf);
        }
    }
}