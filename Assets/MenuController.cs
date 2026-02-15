using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void PlayGame() {
        SceneManager.LoadScene("disillusion_fuck");    
        }

    public void QuitGame() {
        Application.Quit();
        Debug.Log("Quit Game"); 
    }
}
