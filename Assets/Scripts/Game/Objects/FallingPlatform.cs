using UnityEngine;

namespace P3D.Game
{
    public class FallingPlatform : MonoBehaviour
    {
        #region Variables

        [SerializeField] private MovingObject _fallingPlatform;

        #endregion


        #region Unity lifecycle

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag(Tags.Player))
                _fallingPlatform.Move();
        }

        #endregion
    }
}