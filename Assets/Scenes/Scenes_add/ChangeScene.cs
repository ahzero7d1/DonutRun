using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class ChangeScene : MonoBehaviour
{

    public void ChangeSceneBtnAnim(){
        switch (this.gameObject.name)
        {
            case "StoryButton":
                SceneManager.LoadScene("PrologScene");
                break;
        }



    }

    public void changeSceneAnim(){
        //대화 애니메이션이 다 뜨면(=다른 애니메이션으로 조절) StoryScene -> Main
        // SceneManager.LoadScene("Main");
    }



}
