using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneMove : MonoBehaviour
{
    public void GameScene()
    {
        SceneManager.LoadScene("1_Play");
    }
    public void StoreScene()
    {
        SceneManager.LoadScene("StoreScene");
    }
    public void HTPScene()
    {
        SceneManager.LoadScene("HTPScene");
    }
    public void RankScene()
    {
        SceneManager.LoadScene("RankScene");
    }
    public void OverScene()
    {
        SceneManager.LoadScene("GameOver");
    }
    public void StartScene()
    {
        SceneManager.LoadScene("StartScene");
    }
       
}
