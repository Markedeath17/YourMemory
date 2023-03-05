using UnityEngine;
using TMPro;
using System.Collections.Generic;

public class MessageSender : MonoBehaviour
{
    private List<TextMeshProUGUI> _texts = new List<TextMeshProUGUI>();

    [SerializeField] private RectTransform _rectTransform;
    [SerializeField] private TextMeshProUGUI _prefab;

    public void Send(string message)
    {
        if (string.IsNullOrEmpty(message)) return;

        var variant = Instantiate(_prefab, _rectTransform.position, _rectTransform.rotation, _rectTransform);

        variant.text = message;
        
        foreach(var text in _texts)
        {
            text.rectTransform.localPosition += new Vector3(0, 50, 0);
        }

        _texts.Add(variant);
    }
}
