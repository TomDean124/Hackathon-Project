using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    [SerializeField] private int m_sceneToLoad;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void ChangeScenes()
    {
        SceneManager.LoadScene(m_sceneToLoad);
    }
}
