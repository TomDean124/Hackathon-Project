using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    public int _menuSceneInt; 

    void OnTriggerEnter(Collider col)
    {
        SceneManager.LoadScene(_menuSceneInt);
    }
}
