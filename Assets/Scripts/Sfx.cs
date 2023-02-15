using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sfx : MonoBehaviour
{
    static AudioSource audioSource;
    public static AudioClip audioClip;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioClip = Resources.Load<AudioClip>("CoinSound"); // Resources 폴더 안의 "CoinSound" 효과음을 audioClip 변수에 저장
    }

    public static void SoundPlay()
    {
        audioSource.PlayOneShot(audioClip); // SoundPlay() 메소드 실행 시, audioClip 변수에 저장된 "CoinSound" 효과음을 실행
    }
}