using UnityEngine;

public class SendMessageObserver : MonoBehaviour
{
    [SerializeField] private Console _console;
    [SerializeField] private MessageSender _messageSender;

    private void OnEnable() => _console.OnSendMessageEvent += OnSend;

    private void OnSend(string obj)
    {
        _messageSender.Send(obj);
    }

    private void OnDisable() => _console.OnSendMessageEvent -= OnSend;

}
