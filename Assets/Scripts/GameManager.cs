using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public string userName;
    public GameObject inputField;

    public static GameManager instance;

    private void Awake()
    {
        if(instance != null)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void StartButton()
    {
        userName = inputField.GetComponent<Text>().text;
        SceneManager.LoadScene(1);
    }
}
