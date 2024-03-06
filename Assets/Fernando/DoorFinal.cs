using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorFinal : MonoBehaviour
{
    public Transform playerTransform; 
    public float fadeSpeed = 1f; 
    private AudioSource audioSource;
  

    public bool isVisible = false;
    public float time = 5f;

    void Start()
    {
        audioSource = GetComponent<AudioSource>(); 
    }

    void Update()
    {
        if (isVisible == true)
        {
            playerTransform.GetComponent<AudioSource>().volume -= fadeSpeed * Time.deltaTime;
        }
        else
        {
            playerTransform.GetComponent<AudioSource>().volume += fadeSpeed * Time.deltaTime;
        }

    }

   
    private void OnBecameVisible()
    {
        isVisible = true;
        playerTransform.GetComponent<AudioSource>().volume -= fadeSpeed * Time.deltaTime;
    }

    private void OnBecameInvisible()
    {
        Debug.Log("She");
        isVisible = false;
        StartCoroutine(MusicBack(time));
    }

    IEnumerator MusicBack(float time)
    {
        yield return new WaitForSeconds(time);

        if (isVisible == false)
        {
            playerTransform.GetComponent<AudioSource>().volume += fadeSpeed * Time.deltaTime;
            isVisible = false;
        }

        this.gameObject.SetActive(false);
    }
   
}
