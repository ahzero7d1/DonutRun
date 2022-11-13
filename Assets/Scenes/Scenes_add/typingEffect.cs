using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class typingEffect : MonoBehaviour
{
    public Text tx;
    private string m_text = "3 2 1";


    void Start()
    {

        StartCoroutine(_typing());
    }




    IEnumerator _typing()
    {
        yield return new WaitForSeconds(0f);
        for (int i = 0; i <= m_text.Length; i++)
        {
            tx.text = m_text.Substring(0, i);

            yield return new WaitForSeconds(1f);


        }//시작할 때 씬 바뀌면서  time 멈추고 끝나면 글자 사라지고 time 멈추기 끝








    }






}
