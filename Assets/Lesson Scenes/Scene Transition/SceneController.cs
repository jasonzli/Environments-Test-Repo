using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//We need this controller in any scene that will have a level to load
public class SceneController : MonoBehaviour
{
    public Animator transition;
    public string sceneName;
    public float transitionTime = 1f;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            LoadNextScene();
        }
    }

    public void LoadNextScene()
    {
        StartCoroutine(LoadScene(sceneName));
        //Alternatively iterate build index
        //SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex + 1) % SceneManager.sceneCountInBuildSettings);
    }

    IEnumerator LoadScene(string sceneName)
    {
        //Play animation
        transition.SetTrigger("Start");

        //wait for the animation to finish
        yield return new WaitForSeconds(transitionTime);

        //load the scene
        SceneManager.LoadScene(sceneName);
    }
}
