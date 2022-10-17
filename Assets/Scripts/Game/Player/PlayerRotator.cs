using UnityEngine;

namespace P3D.Game
{
    public class PlayerRotator : MonoBehaviour
    {
        #region Variables

        [SerializeField] private float _speed = 0.1f;

        private Vector3 _previousMousePosition;

        #endregion


        #region Unity lifecycle

        private void Start() =>
            _previousMousePosition = Input.mousePosition;

        private void Update()
        {
            Vector3 mousePosition = Input.mousePosition;
            Vector3 delta = _previousMousePosition - mousePosition;
            float rotationDelta = delta.x;
            transform.Rotate(transform.up, rotationDelta * _speed * Time.deltaTime);
            _previousMousePosition = mousePosition;
        }

        #endregion
    }
}