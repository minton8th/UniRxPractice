using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;

public class SampleSceneController : MonoBehaviour
{
    [SerializeField] private Button button;

    private int coin = 0;

    private void Start()
    {
        button.onClick.AddListener(OnButtonClick);
    }


    public void OnButtonClick()
    {
        coin += 100;
        User user = new User(coin);
        MessageBroker.Default.Publish<User>(user);
    }
}
