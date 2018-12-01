using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour {

    // Use this for initialization

    private bool isSceneLoading;
    public GameObject loading;
    public GameObject charPanel;
    public Image loadingImage;
    public Image charImage;
    private AsyncOperation async;

    public Sprite[] sprite;
    public int currentIndex;
    public GameConfig gameConfig;
    void Start() {
        isSceneLoading = false;


    }

    // Update is called once per frame
    void Update() {
        if (isSceneLoading)
        {
            loadingImage.fillAmount = async.progress;
            if (async.progress == 1)
            {
                isSceneLoading = false;
            }
        }
    }

    public void LoadGame()
    {
        async = SceneManager.LoadSceneAsync("Gameplay");
        isSceneLoading = true;
        loading.SetActive(true);
        loadingImage.fillAmount = 0;
    }

    public void OpenCharPanel()
    {
        charPanel.SetActive(true);
        currentIndex = 0;
        charImage.sprite = sprite[currentIndex];

    }

    public void CloseCharPanel()
    {
        charPanel.SetActive(false);
    }

    public void Left()
    {
        currentIndex--;
        if (currentIndex < 0)
        {
            currentIndex = sprite.Length-1;
        }
        charImage.sprite = sprite[currentIndex];
        gameConfig.choosedCharacter = currentIndex;
    }

    public void Right()
    {
        currentIndex++;
        if (currentIndex >= sprite.Length)
        {
            currentIndex = 0;
        }
        charImage.sprite = sprite[currentIndex];
        gameConfig.choosedCharacter = currentIndex;

    }
}
