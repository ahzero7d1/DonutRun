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
        }


    }

    public void changeSceneAnim(){
        //대화 애니메이션이 다 뜨면 StoryScene -> Main
        // SceneManager.LoadScene("Main");
    }



}
