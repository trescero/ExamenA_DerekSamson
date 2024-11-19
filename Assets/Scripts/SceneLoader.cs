using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] private string scene;

    public void SceneChange() {
            SceneManager.LoadScene(scene);
    }
}
