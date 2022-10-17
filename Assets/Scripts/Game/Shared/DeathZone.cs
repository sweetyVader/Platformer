using System.Collections;
using UnityEngine;

namespace P3D.Game
{
    public class DeathZone : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            // TODO: Refactor in future
            PlayerAnimator playerAnimator = FindObjectOfType<PlayerAnimator>();
            playerAnimator.PlayerDead();
         
            StartCoroutine(ReloadScene());
        }

        IEnumerator ReloadScene()
        {
            yield return new WaitForSeconds(3f);
            Reloader.Reload();
        }
    }
}