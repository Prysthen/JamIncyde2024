using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NoteScript : MonoBehaviour
{
    public GameObject UI;
    public TextMeshProUGUI text;
    public NoteSO noteSO;
    private void OnMouseDown()
    {
        UI.SetActive(true);
        text.text = noteSO.text;
    }
    private void OnTriggerExit(Collider other)
    {
        UI.SetActive(true);
        text.text = noteSO.text;
    }
}
