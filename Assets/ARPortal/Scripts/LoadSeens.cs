using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class LoadSeens : MonoBehaviour
{
    public void SeenLoader(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
