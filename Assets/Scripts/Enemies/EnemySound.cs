using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySound : MonoBehaviour
{
    float currentCooldown = 0;

    [SerializeField]
    private AudioClip[] enemyClip;  
    // Update is called once per frame
    void Update()
    {
        if (currentCooldown <= 0)
        {
            currentCooldown = Random.Range(10, 120);
            PlayRandomSound();
        }
        else
            currentCooldown -= Time.deltaTime;
    }

    void PlayRandomSound()
    {
        int r = Random.Range(0, enemyClip.Length);

        AudioSource.PlayClipAtPoint(enemyClip[r], transform.position, 100f);
    }
}
