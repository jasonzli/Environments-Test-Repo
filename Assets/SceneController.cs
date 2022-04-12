using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public Animator UIFade;
    public string sceneToLoad;
    public string AnimationToPlay;

    //This is a coroutine
    IEnumerator PlayTransition(float waitTime = 1f, float delay = 0f)
    {
        yield return new WaitForSeconds(delay); //to do it after a wait

        UIFade.SetTrigger(AnimationToPlay); //trigger the animation

        yield return new WaitForSeconds(waitTime); //wait until animation is finished to transition

        SceneManager.LoadScene(sceneToLoad);
    }

    void Start()
    {
        //Play a 1 second animation in 5 seconds 
        StartCoroutine(PlayTransition(1f, 5f));
    }

    void Update()
    {
        //Change scene on input.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(PlayTransition(1f, 0f)); //Immediately change scene;
        }
    }

    //A function that changes scene immediately
    void ChangeScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }

}
