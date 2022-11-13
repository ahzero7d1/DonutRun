using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class ChangeScene : MonoBehaviour
{

    public void ChangeSceneBtn()
    {
        switch (this.gameObject.name)
        {
            case "StoryButton":
                SceneManager.LoadScene("StoryScene");
                break;
            case "StoryButton2":
                SceneManager.LoadScene("StoryScene2");
                break;
            case "MainButton":
                SceneManager.LoadScene("SampleScene");
                break;
        }


    }



}
