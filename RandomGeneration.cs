using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomGeneration : MonoBehaviour
{
    [SerializeField] private string[] messages;
    [SerializeField] private Text msgText;
    [SerializeField] private Button UIButton;

    public void StartProcess()
    {
        msgText.text = null;
        StartCoroutine(GenerateMessage());
    }

    IEnumerator GenerateMessage()
    {
        UIButton.interactable = false;
        yield return new WaitForSeconds(2f);
        msgText.text = messages[Random.Range(0, messages.Length)];
        UIButton.interactable = true;
    }
}
