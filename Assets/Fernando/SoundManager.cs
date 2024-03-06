using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource[] AS; // 0 OST, 1 SE 2 SFX
    
    public void PlayOST (AudioClip _clip)
    {
        AS[0].clip = _clip;
        AS[0].Play();
    }

    public void PlaySE(AudioClip _clip)
    {
        AS[0].clip = _clip;
        AS[0].Play();
    }
    public void PlaySFX(AudioClip clip)
    {
        AS[1].PlayOneShot(AS[1].clip);
    }
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
