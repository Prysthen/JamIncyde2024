using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class SceneSelect : MonoBehaviour
{
    public SceneSO scene;
    public GameObject Trasitionn;
    public Animator animator;
    [SerializeField] private AnimationClip animationClip;
    private void Start()
    {
        animator = Trasitionn.GetComponent<Animator>();
        Application.targetFrameRate = 60;
    }
    public void OnSceneSelect()
    {
        StartCoroutine(SceneChange());
    }

    IEnumerator SceneChange()
    {
        animator = Trasitionn.GetComponent<Animator>();
        animator.SetTrigger("SceneEnd");
        yield return new WaitForSeconds(animationClip.length);
        SceneManager.LoadSceneAsync(scene.name);
    }
}
