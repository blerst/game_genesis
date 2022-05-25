using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayMenu : MonoBehaviour
{
    public void Back ()
    {
        SceneManager.LoadScene(0);
    }
    public void Easy ()
    {
        SceneManager.LoadScene(2);
    }
    public void Normal ()
    {
        SceneManager.LoadScene(3);
    }
    public void Hard ()
    {
        SceneManager.LoadScene(4);
    }
}
