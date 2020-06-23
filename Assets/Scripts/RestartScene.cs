using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RestartScene : MonoBehaviour
{
    public string _scene_name;
    public void Reset_All()
    {
        SceneManager.LoadScene(_scene_name);
    }
}
