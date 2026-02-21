using UnityEngine;
using UnityEngine.SceneManagement; 

public class UIManager : MonoBehaviour
{
    [SerializeField] private int m_sceneToLoadIndex = 0; 
    [SerializeField] private int m_restartSceneIndex = 1;

    void OnEnable()
    {
        GameManager.OnDeath += ShowRestartGameMenu; 
    }

    void OnDisable()
    {
        GameManager.OnDeath -= ShowRestartGameMenu; 
    }

    private void ShowRestartGameMenu()
    {
        SceneManager.LoadScene(m_restartSceneIndex);
    }

    public void RestartGame()
    {
        Debug.Log("Attempting to load back into the scene!");
        SceneManager.LoadScene(m_sceneToLoadIndex);
    } 

}
