using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class typingEffect : MonoBehaviour
{
    public Text tx;
    private string m_text = "아니 이걸 언제 기다리냔 말이야?";


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

            yield return new WaitForSeconds(0.1f);


        }








    }






}
