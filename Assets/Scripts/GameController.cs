using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System;



public class GameController : MonoBehaviour
{
    // [SerializeField]
    // private TextMeshProUGUI textTitle;
    [SerializeField]
    private TextMeshProUGUI textRun;

    [SerializeField]
    private TextMeshProUGUI textCoinCount;
    private int coinCount = 0;

    public bool IsGameStart { private set; get; }
    

    private void Awake()
    {
        IsGameStart = false;

        // textTitle.enabled = true;
        textRun.enabled = true;
        textCoinCount.enabled = false;

    }

    private IEnumerator Start()
    {
        // 마우스 왼쪽 버튼을 누르기 전까지 시작하지 않고 대기
        while (true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                IsGameStart = true;

                // textTitle.enabled = false;
                textRun.enabled = false;
                textCoinCount.enabled = true;

                break;
            }

            yield return null;
        }
    }

    public void IncreaseCoinCount()
    {
        coinCount++;
        textCoinCount.text = coinCount.ToString();
    }

    /*private void DontDestroyOnLoad(int coinCount)
    {
        throw new NotImplementedException();
    }*/

    public void GameOver()
    {
        //현재 씬을 다시 로드
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        SceneManager.LoadScene("GameOver");

    }
}