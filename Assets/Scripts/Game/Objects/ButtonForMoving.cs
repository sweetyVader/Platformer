using DG.Tweening;
using UnityEngine;

namespace P3D.Game
{
    public class ButtonForMoving : MonoBehaviour
    {
        #region Variables

        [SerializeField] private MovingObject _button;
        [SerializeField] private MovingObject _movingBlock;

        #endregion


        #region Unity lifecycle

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag(Tags.Player))
                MoveObject();
        }

        #endregion


        #region Private methods

        private void MoveObject()
        {
            _button.Move();
            _movingBlock.Move();
            _movingBlock.transform.DOShakePosition(1f, new Vector3(1f, 0.5f, 0.5f), 40);
        }

        #endregion
    }
}