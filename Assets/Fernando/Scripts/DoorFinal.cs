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

    public GameObject[] spawnpoints;
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
        Debug.Log("Visible");
        isVisible = true;
        playerTransform.GetComponent<AudioSource>().volume -= fadeSpeed * Time.deltaTime;
    }

    private void OnBecameInvisible()
    {
        Debug.Log("Invisible");
        isVisible = false;
        StartCoroutine(MusicBack(time));


    }
    private void OnDisable()
    {
        StartCoroutine(MusicBack(time));

        enabled = true;

     int i =  Random.Range(0, spawnpoints.Length);

        transform.position = spawnpoints[i].transform.position;
    }


    IEnumerator MusicBack(float time)
    {
        yield return new WaitForSeconds(time);

        if (isVisible == false)
        {
            playerTransform.GetComponent<AudioSource>().volume += fadeSpeed * Time.deltaTime;
            isVisible = false;
        }
        else
        {
            new WaitForSeconds(time * 3);
            isVisible = false;
        }

       
    }
   
}
