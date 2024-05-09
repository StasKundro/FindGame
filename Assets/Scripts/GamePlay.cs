using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePlay : MonoBehaviour
{
    //сколько максимум ищем объектов
    public int maxObj = 5;
    //сколько нашли
    public int currrectObj;

    public TMP_Text scoreText;
    public GameObject winEff;

    private void FixedUpdate()
    {
        scoreText.text = currrectObj.ToString() + " / " + maxObj.ToString();

        if (currrectObj >= maxObj)
        {
            winEff.SetActive(true);
            StartCoroutine(Rest(3f));
        }
    }

    IEnumerator Rest(float Secs)
    {
        yield return new WaitForSeconds(Secs);
        SceneManager.LoadScene("Game");
    }

    public void GoMain()
    {
        SceneManager.LoadScene("Menu");
    }

}
