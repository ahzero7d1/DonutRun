using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Success_Text : MonoBehaviour
{
    public void Setup() {
        //gameObject.text = ("도넛 "+GameManager.donutPoint+" 획득!!").ToString();
        gameObject.SetActive(true);
    }
}
