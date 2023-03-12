using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    [SerializeField]
    AudioClip laughClip;
    // Start is called before the first frame update
    void Start()
    {
        AudioSource.PlayClipAtPoint(laughClip, transform.position, 10f);
    }
}
