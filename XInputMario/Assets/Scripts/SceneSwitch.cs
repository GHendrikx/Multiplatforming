using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public void SwitchScene(int index)
    {
        if (index == 3)
            Application.Quit();

        SceneManager.LoadScene(index);
    
    }
}
