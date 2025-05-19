using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI score;

    // Update is called once per frame
    void Update()
    {
        score.text = player.position.z.ToString("0");
    }

    public void Quit()
    {
        Debug.Log("Game interrupted!");
        SceneManager.LoadScene("Credits");
    }
}
