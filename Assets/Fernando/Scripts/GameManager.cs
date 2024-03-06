using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int counter;
    public TextMeshProUGUI text;
    public SceneSO scene;
    public GameObject Trasitionn;
    public Animator animator;
    [SerializeField] private AnimationClip animationClip;
    public void PointExtra()
    {
        counter++;
        text.text = counter.ToString();

        if (counter <= 7)
        {
            SceneManager.LoadSceneAsync(scene.ToString());
            StartCoroutine(SceneChange());
        }

    }

    IEnumerator SceneChange()
    {
        animator = Trasitionn.GetComponent<Animator>();
        animator.SetTrigger("SceneEnd");
        yield return new WaitForSeconds(animationClip.length);
        SceneManager.LoadSceneAsync(scene.name);
    }
}
