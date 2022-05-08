using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coin1 : MonoBehaviour
{
    [SerializeField] private Text _text;

    int score;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coins"))
        {
            score++;
            Destroy(collision.gameObject);
            _text.text = score.ToString();
        }
    }

}
