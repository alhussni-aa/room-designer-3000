using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Options : MonoBehaviour
{
    public void GoToRoom1()
    {
        SceneManager.LoadScene("SampleRoom1", LoadSceneMode.Single);
    }

    public void GoToRoom2()
    {
        SceneManager.LoadScene("SampleRoom2", LoadSceneMode.Single);
    }

    public void GoToRoom3()
    {
        SceneManager.LoadScene("SampleRoom3", LoadSceneMode.Single);
    }

    public void GoToDesigner()
    {
        SceneManager.LoadScene("Designer", LoadSceneMode.Single);
    }
    
    public void GoToChoose () 
    {   
        SceneManager.LoadScene("Choose", LoadSceneMode.Single);
    }

    public void ReturnToMenu () 
    {   
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }

    public void QuitApp ()
    {
        Application.Quit();
    }
}
