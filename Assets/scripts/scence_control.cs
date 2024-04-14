using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scence_control : MonoBehaviour
{
    public void _jumpScence(string scence_name)
    {
        StartCoroutine(WaitAndDoSomething(scence_name));
    }
    IEnumerator WaitAndDoSomething(string scence_name)
    {
      
        yield return new WaitForSeconds(0.5f); // µÈ´ý0.5Ãë
        SceneManager.LoadScene(scence_name);

    }
    public void _quitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
Application.Quit();
#endif
    }

}
