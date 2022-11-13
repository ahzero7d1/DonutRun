using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class ChangeScene : MonoBehaviour
{
    public void FixedUpdate(){
        Scene scene = SceneManager.GetActiveScene();
        Debug.Log(scene.name);
        
        if(scene.name == "PrologScene"){
            Invoke("ChangeToMain",13f);
        }
    }

    public void ChangeSceneBtnAnim(){
        switch (this.gameObject.name)
        {
            case "StoryButton":
                SceneManager.LoadScene("PrologScene");
                break;
        }
    }

    public void ChangeToMain(){
        SceneManager.LoadScene("Main");

    }



}
