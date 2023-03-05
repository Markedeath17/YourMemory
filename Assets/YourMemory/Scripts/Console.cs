using System;
using TMPro;
using UnityEngine;

public class Console : MonoBehaviour
{
    public event Action<string> OnSendMessageEvent;

    [SerializeField] private TMP_InputField _input;

    public void Send() => OnSendMessageEvent?.Invoke(_input.text);
}
