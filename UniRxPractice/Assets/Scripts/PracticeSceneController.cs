using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;

public class PracticeSceneController : MonoBehaviour
{
    [SerializeField] private Text coinText;
    // Start is called before the first frame update
    void Start()
    {
        coinText.text = "0";
        MessageBroker.Default.Receive<User>().Subscribe((user) =>
        {
            if (coinText)
            {
                coinText.text = user.coin.ToString();
            }
        });
    }
}
