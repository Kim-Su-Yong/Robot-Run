﻿using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField]
    private GameObject coinEffectPrefab;
    private float rotateSpeed;

    private void Awake()
    {
        rotateSpeed = Random.Range(0, 360);
    }

    private void Update()
    {
        // 코인 오브젝트 회전
        transform.Rotate(Vector3.right * rotateSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        //코인 오브젝트 획독 효과(coinEffectPrefab) 생성
        GameObject clone = Instantiate(coinEffectPrefab);
        clone.transform.position = transform.position;

        //코인 오브젝트 삭제
        Destroy(gameObject);

        //코인 획득시 효과음 재생
        Sfx.SoundPlay();
    }
}
