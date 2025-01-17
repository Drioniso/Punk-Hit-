using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {
    [SerializeField] private int sceneToLoad;

    public void LoadNextScene() {
        SceneManager.LoadScene(sceneToLoad, LoadSceneMode.Single);
    }
}
