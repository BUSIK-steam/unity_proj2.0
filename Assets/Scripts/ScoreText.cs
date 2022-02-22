using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreText : MonoBehaviour
{

    [SerializeField] int score = 0;
    [SerializeField] TextMeshProUGUI tmpro;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (tmpro)
        {
            tmpro.text = score.ToString();
        }
    }

    public void AddScore() { score++; }
}
