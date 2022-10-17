using UnityEngine.SceneManagement;

namespace P3D.Game
{
    public static class Reloader
    {
        #region Public methods

        public static void Reload() =>
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        #endregion
    }
}