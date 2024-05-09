using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlusScript : MonoBehaviour
{
    public GamePlay gamePlay;
    public AudioClip clip;
    public AudioSource source;  

    public void GoPlus()
    {
        gamePlay.currrectObj += 1;
        source.PlayOneShot(clip);
        Destroy(gameObject); // удаляем во избежании повторного клика
    }
}
