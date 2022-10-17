using UnityEngine;

namespace P3D.Game
{
    public class PlayerAnimator : MonoBehaviour
    {
        #region Variables

        [SerializeField] private Animator _animator;

        #endregion


        #region Public methods

        public void PlayerDead() =>
            _animator.SetTrigger("Death");

        #endregion
    }
}