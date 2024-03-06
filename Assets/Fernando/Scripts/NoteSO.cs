using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[CreateAssetMenu(fileName = "NewMyScriptableObject", menuName = "ScriptableObjects/NoteText")]
public class NoteSO : ScriptableObject
{
    [TextArea (3, 10)]
    public string text;

}
