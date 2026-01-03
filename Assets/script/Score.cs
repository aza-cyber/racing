using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public Transform car;
    public TextMeshProUGUI scoreText;

    void Update()
    {
        scoreText.text = car.position.z.ToString("0");
    }
}
